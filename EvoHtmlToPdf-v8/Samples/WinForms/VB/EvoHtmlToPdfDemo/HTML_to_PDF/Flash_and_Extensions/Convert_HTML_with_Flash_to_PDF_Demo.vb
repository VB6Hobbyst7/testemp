Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions
	Partial Public Class Convert_HTML_with_Flash_to_PDF_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Enable extensions including the Flash support
			' The converter does not have a built-in Flash player and it uses the installed Flash plugin
			' for Google Chrome or Mozilla Firefox
			htmlToPdfConverter.ExtensionsEnabled = extensionsEnabledCheckBox.Checked

			' Set an adddional delay in seconds to wait for Flash to run
			' Set this property to 0 if you want to start conversion immediately
			htmlToPdfConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Flash_to_PDF.pdf"
			Try
				' Convert the HTML page with Flash to a PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
