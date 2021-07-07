Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
	Partial Public Class Digital_Signatures_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Digital_Signatures.pdf"
			Try
				Dim htmlWithDigitalSignatureMarker As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Add a HTML string with a marker for digital signature to PDF document
				Dim htmlToPdfElement As New HtmlToPdfElement(htmlWithDigitalSignatureMarker, baseUrl)
				pdfPage.AddElement(htmlToPdfElement)

				' Make the HTML element with 'digital_signature_element' mapping ID a link to digital signature properties
				Dim digitalSignatureMapping As HtmlElementMapping = htmlToPdfElement.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("digital_signature_element")
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

		Private Sub Digital_Signatures_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Digital_Signatures.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
