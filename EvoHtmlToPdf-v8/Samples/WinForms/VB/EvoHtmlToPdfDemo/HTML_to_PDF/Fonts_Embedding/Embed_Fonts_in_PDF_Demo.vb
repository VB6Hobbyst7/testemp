Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding
	Partial Public Class Embed_Fonts_in_PDF_Demo
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

			' Set if the fonts are embedded in the generated PDF document
			' Leave it not set to embed the fonts in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.EmbedFonts = embedFontsCheckBox.Checked

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Embed_Fonts_in_PDF.pdf"
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
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
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
