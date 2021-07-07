Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Header_Footer_Auto_Resize_Demo
		Inherits UserControl
		' Define the PDF Document object as a class member to make it accessible in the headerHtml_NavigationCompletedEvent handler
		' where the header height will be automatically adjusted
		Private pdfDocument As Document

		' Indicates if a line should be drawn at the botom of the header
		Private drawHeaderLine As Boolean = True

		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			pdfDocument = New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor

			Dim headerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Header_HTML.html")
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Auto_Resize_Header_Footer.pdf"
			Try
				' Add the header to PDF document
				If autoResizeHeaderRadioButton.Checked Then
					' Create the document header with a default height
					' It will be automatically resized in headerHtml_NavigationCompletedEvent handler
					pdfDocument.AddHeaderTemplate(50)

					' Create a HTML element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Install a handler where to create the document header based on HTML element height
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Add the HTML element to header
					' When the element is rendered in header by converter, the headerHtml_NavigationCompletedEvent handler 
					' will be invoked and the header height will be automatically calculated
					pdfDocument.Header.AddElement(headerHtml)

					' Uninstall the handler
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent
				Else
					' Create the document header with a fixed height
					pdfDocument.AddHeaderTemplate(Single.Parse(headerHeightTextBox.Text))

					' Create a HTML to PDF element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Set the HTML element to fit the container height
					headerHtml.FitHeight = True

					' Add HTML element to fit the fixed header height
					pdfDocument.Header.AddElement(headerHtml)

				End If

				' Draw a line at the header bottom
				If drawHeaderLine Then
					Dim headerWidth As Single = pdfDocument.Header.Width
					Dim headerHeight As Single = pdfDocument.Header.Height

					' Create a line element for the bottom of the header
					Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

					' Set line color
					headerLine.ForeColor = Color.Gray

					' Add line element to the bottom of the header
					pdfDocument.Header.AddElement(headerLine)
				End If

				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to document
				pdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The PDF creation failed
				MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				pdfDocument.Close()

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		''' <summary>
		''' This handler is called after the navigation to header HTML completed. The document header is resized in this event handler
		''' </summary>
		''' <param name="eventParams">The event parameter containing the HTML content size in pixels and points</param>
		Private Sub headerHtml_NavigationCompletedEvent(ByVal eventParams As NavigationCompletedParams)
			' Get the header HTML width and height from event parameters
			Dim headerHtmlWidth As Single = eventParams.HtmlContentWidthPt
			Dim headerHtmlHeight As Single = eventParams.HtmlContentHeightPt

			' Get the header width
			Dim headerWidth As Single = pdfDocument.Header.Width

			' Calculate a resize factor to fit the header width
			Dim resizeFactor As Single = 1
			If headerHtmlWidth > headerWidth Then
				resizeFactor = headerWidth / headerHtmlWidth
			End If

			' Calculate the header height to preserve the HTML aspect ratio
			Dim headerHeight As Single = headerHtmlHeight * resizeFactor

			If Not(headerHeight < pdfDocument.Pages(0).PageSize.Height - pdfDocument.Pages(0).Margins.Top - pdfDocument.Pages(0).Margins.Bottom) Then
				Throw New Exception("The header height cannot be bigger than PDF page height")
			End If

			' Set the calculated header height
			pdfDocument.Header.Height = headerHeight
		End Sub

		Private Sub autoResizeHeaderRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles autoResizeHeaderRadioButton.CheckedChanged
			fixedHeightOptionsPanel.Visible = fitHeaderHeightRadioButton.Checked
		End Sub

		Private Sub fitHeaderHeightRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles fitHeaderHeightRadioButton.CheckedChanged
			fixedHeightOptionsPanel.Visible = fitHeaderHeightRadioButton.Checked
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
