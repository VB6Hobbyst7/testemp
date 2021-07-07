Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
	Partial Public Class Add_Elements_in_Background_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Set a handler for BeforeRenderPdfPageEvent where to set the background image in each PDF page before main content is rendered
			AddHandler htmlToPdfConverter.BeforeRenderPdfPageEvent, AddressOf htmlToPdfConverter_BeforeRenderPdfPageEvent

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Add_Elements_in_Background.pdf"
			Try
				If convertUrlRadioButton.Checked Then
					Dim url As String = urlTextBox.Text

					' Convert the HTML page given by an URL to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				Else
					Dim htmlString As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with a base URL to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertHtml(htmlString, baseUrl)

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				End If
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow

				' Uninstall the handler
				RemoveHandler htmlToPdfConverter.BeforeRenderPdfPageEvent, AddressOf htmlToPdfConverter_BeforeRenderPdfPageEvent
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		''' <summary>
		''' The BeforeRenderPdfPageEvent event handler where a background image is set in each PDF page
		''' before the main content is rendered
		''' </summary>
		''' <param name="eventParams">The event parameter containing the PDF page being rendered</param>
		Private Sub htmlToPdfConverter_BeforeRenderPdfPageEvent(ByVal eventParams As BeforeRenderPdfPageParams)
			If Not addBackgroundImageCheckBox.Checked Then
				Return
			End If

			' Get the PDF page being rendered
			Dim pdfPage As PdfPage = eventParams.Page

			' Get the PDF page drawable area width and height
			Dim pdfPageWidth As Single = pdfPage.ClientRectangle.Width
			Dim pdfPageHeight As Single = pdfPage.ClientRectangle.Height

			' The image to be added as background
			Dim backgroundImagePath As String = "DemoAppFiles\Input\Images\background.jpg"

			' The image element to add in background
			Dim backgroundImageElement As New ImageElement(0, 0, pdfPageWidth, pdfPageHeight, backgroundImagePath)
			backgroundImageElement.KeepAspectRatio = True
			backgroundImageElement.EnlargeEnabled = True

			' Add the background image element to PDF page before the main content is rendered
			pdfPage.AddElement(backgroundImageElement)
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
