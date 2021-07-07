Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_With_Existing_PDF_Demo
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

			' Set the PDF file to be inserted before conversion result
			htmlToPdfConverter.PdfDocumentOptions.AddStartDocument(pdfBeforeTextBox.Text)

			' Set the PDF file to be added after conversion result
			htmlToPdfConverter.PdfDocumentOptions.AddEndDocument(pdfAfterTextBox.Text)

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Merge_HTML_with_Existing_PDF.pdf"
			Try
				' The URL to convert
				Dim url As String = urlTextBox.Text

				' Convert the HTML page to a PDF document and add the external PDF documents
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
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

		Private Sub Merge_With_Existing_PDF_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfBeforeTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf"
			pdfAfterTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
