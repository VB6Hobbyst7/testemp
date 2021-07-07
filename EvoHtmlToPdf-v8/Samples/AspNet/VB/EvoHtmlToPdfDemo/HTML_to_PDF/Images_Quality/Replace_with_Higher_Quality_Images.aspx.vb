Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
	Partial Public Class Replace_with_Higher_Quality_Images
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Select all images from HTML page
			htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { "img" }

			' Exclude the original images from rendering becuase they will be replaced by an image from local file system
			htmlToPdfConverter.HiddenHtmlElementsSelectors = New String() { "img" }

			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML string with images to replace to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				' Replace the images selected in HTML using special attributes with images from local file system
				For Each imageElementInfo As HtmlElementMapping In htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					Dim imagePdfPage As PdfPage = imageElementInfo.PdfRectangles(0).PdfPage
					Dim imageRectangle As RectangleF = imageElementInfo.PdfRectangles(0).Rectangle

					Dim newImageElement As New ImageElement(imageRectangle.X, imageRectangle.Y, imageRectangle.Width, imageRectangle.Height, Server.MapPath("~/DemoAppFiles/Input/Images/box.jpg"))
					newImageElement.EnlargeEnabled = True
					imagePdfPage.AddElement(newImageElement)
				Next imageElementInfo

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Replace_with_Higher_Quality_Images.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Images_Quality/Replace_with_Higher_Quality.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Images_Quality/Replace_with_Higher_Quality.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Images_Quality")
				Master.SelectNode("Replace_Images")
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

		Protected Sub viewHtmlLinkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect(urlTextBox.Text)
		End Sub
	End Class
End Namespace