Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_Auto_Resize_Demo
		Inherits UserControl
		' Define the HTML to PDF converter object as a class member to make it accessible in the headerHtml_NavigationCompletedEvent handler
		' where the header height will be automatically adjusted
		Private htmlToPdfConverter As HtmlToPdfConverter

		' Indicates if a line should be drawn at the botom of the header
		Private drawHeaderLine As Boolean = True

		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			htmlToPdfConverter = New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Enable header in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowHeader = True

			Cursor = Cursors.WaitCursor

			Dim headerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Header_HTML.html")
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Auto_Resize_Header_Footer.pdf"
			Dim documentObject As Document = Nothing
			Try
				If autoResizeHeaderRadioButton.Checked Then
					' Create a HTML element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Install a handler where to set the automatically calculated header height
					AddHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Add the HTML element to header
					' When the element is rendered in header by converter, the headerHtml_NavigationCompletedEvent handler 
					' will be invoked and the header height will be automatically calculated
					htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

					' Call the converter to produce a Document object
					documentObject = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

					' Uninstall the handler
					RemoveHandler headerHtml.NavigationCompletedEvent, AddressOf headerHtml_NavigationCompletedEvent

					' Draw a line at the header bottom
					If drawHeaderLine Then
						Dim headerWidth As Single = documentObject.Header.Width
						Dim headerHeight As Single = documentObject.Header.Height

						' Create a line element for the bottom of the header
						Dim headerLine As New LineElement(0, headerHeight-1, headerWidth, headerHeight-1)

						' Set line color
						headerLine.ForeColor = Color.Gray

						' Add line element to the bottom of the header
						documentObject.Header.AddElement(headerLine)
					End If

					' Save the PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = documentObject.Save()

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				Else
					' Create a HTML to PDF element to be added in header
					Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

					' Set a fixed header height in points
					htmlToPdfConverter.PdfHeaderOptions.HeaderHeight = Single.Parse(headerHeightTextBox.Text)

					' Set the HTML element to fit the container height
					headerHtml.FitHeight = True

					' Add HTML element to fit the fixed header height
					htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

					' Draw a line at the header bottom
					If drawHeaderLine Then
						' Calculate the header width based on PDF page size and margins
						Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

						' Calculate header height
						Dim headerHeight As Single = htmlToPdfConverter.PdfHeaderOptions.HeaderHeight

						' Create a line element for the bottom of the header
						Dim headerLine As New LineElement(0, headerHeight-1, headerWidth, headerHeight-1)

						' Set line color
						headerLine.ForeColor = Color.Gray

						' Add line element to the bottom of the header
						htmlToPdfConverter.PdfHeaderOptions.AddElement(headerLine)
					End If

					' Convert the HTML page to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				End If
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				If documentObject IsNot Nothing Then
					documentObject.Close()
				End If

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

			' Calculate the header width from coverter settings
			Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

			' Calculate a resize factor to fit the header width
			Dim resizeFactor As Single = 1
			If headerHtmlWidth > headerWidth Then
				resizeFactor = headerWidth / headerHtmlWidth
			End If

			' Calculate the header height to preserve the HTML aspect ratio
			Dim headerHeight As Single = headerHtmlHeight * resizeFactor

			If Not(headerHeight < htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Height - htmlToPdfConverter.PdfDocumentOptions.TopMargin - htmlToPdfConverter.PdfDocumentOptions.BottomMargin) Then
				Throw New Exception("The header height cannot be bigger than PDF page height")
			End If

			' Set the calculated header height
			htmlToPdfConverter.PdfDocumentOptions.DocumentObject.Header.Height = headerHeight
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
