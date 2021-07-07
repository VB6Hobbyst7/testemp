Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
	Partial Public Class Digital_Signatures_Demo
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

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Digital_Signatures.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				Dim htmlWithDigitalSignatureMarker As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with a marker for digital signature to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithDigitalSignatureMarker, baseUrl)

				' Make the HTML element with 'digital_signature_element' mapping ID a link to digital signature properties
				Dim digitalSignatureMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("digital_signature_element")
				If digitalSignatureMapping IsNot Nothing Then
					Dim digitalSignaturePage As PdfPage = digitalSignatureMapping.PdfRectangles(0).PdfPage
					Dim digitalSignatureRectangle As RectangleF = digitalSignatureMapping.PdfRectangles(0).Rectangle

					Dim certificateFilePath As String = "DemoAppFiles\Input\Certificates\evopdf.pfx"

					' Get the certificate from password protected PFX file
					Dim certificates As DigitalCertificatesCollection = DigitalCertificatesStore.GetCertificates(certificateFilePath, "evopdf")
					Dim certificate As DigitalCertificate = certificates(0)

					' Create the digital signature
					Dim signature As New DigitalSignatureElement(digitalSignatureRectangle, certificate)
					signature.Reason = "Protect the document from unwanted changes"
					signature.ContactInfo = "The contact email is support@evopdf.com"
					signature.Location = "Development server"
					digitalSignaturePage.AddElement(signature)
				End If

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
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

		Private Sub Digital_Signatures_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Digital_Signatures.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
