Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
	Partial Public Class Digital_Signatures
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

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

					Dim certificateFilePath As String = Server.MapPath("~/DemoAppFiles/Input/Certificates/evopdf.pfx")

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

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Digital_Signatures.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Digital_Signatures.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/PDF_Security/Digital_Signatures.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/PDF_Security/Digital_Signatures.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_PDF_Security")
				Master.SelectNode("PDF_Creator_Digital_Signatures")
			End If
		End Sub

		Protected Sub demoMenu_MenuItemClick(ByVal sender As Object, ByVal e As MenuEventArgs)
			Select Case e.Item.Value
				Case "Live_Demo"
					demoMultiView.SetActiveView(liveDemoView)
				Case "Description"
					demoMultiView.SetActiveView(descriptionView)
				Case "Sample_Code"
					demoMultiView.SetActiveView(sampleCodeView)
				Case Else
			End Select
		End Sub
	End Class
End Namespace