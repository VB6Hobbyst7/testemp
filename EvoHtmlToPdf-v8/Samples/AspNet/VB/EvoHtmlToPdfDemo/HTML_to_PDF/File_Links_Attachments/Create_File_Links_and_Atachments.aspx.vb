Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
	Partial Public Class Create_File_Links_and_Atachments
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

			Dim pdfDocument As Document = Nothing
			Try
				Dim htmlWithLinksAndAttachMarkers As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with markers for file links and attachments to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithLinksAndAttachMarkers, baseUrl)

				' Display the attachments panel when the PDF document is opened in a PDF viewer
				pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments

				' Create File Attachments

				' Create an attachment from a file without icon
				Dim fileAttachmentPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_File.txt")
				pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File")

				' Create an attachment from a stream without icon
				Dim fileStreamAttachmentPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_Stream.txt")
				Dim attachmentStream As New System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
				pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream")

				' Create an attachment from file with paperclip icon in PDF
				Dim attachFromFileIconMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("attach_from_file_icon")
				If attachFromFileIconMapping IsNot Nothing Then
					Dim attachFromFilePage As PdfPage = attachFromFileIconMapping.PdfRectangles(0).PdfPage
					Dim attachFromFileIconRectangle As RectangleF = attachFromFileIconMapping.PdfRectangles(0).Rectangle

					Dim fileAttachmentWithIconPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_File_Icon.txt")

					' Create the attachment from file
					Dim attachFromFileElement As New FileAttachmentElement(attachFromFileIconRectangle, fileAttachmentWithIconPath)
					attachFromFileElement.IconType = FileAttachmentIcon.Paperclip
					attachFromFileElement.Text = "Attachment from File with Paperclip Icon"
					attachFromFileElement.IconColor = Color.Blue
					attachFromFilePage.AddElement(attachFromFileElement)
				End If

				' Create an attachment from stream with pushpin icon in PDF
				Dim attachmentStreamWithIcon As System.IO.FileStream = Nothing
				Dim attachFromStreamIconMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("attach_from_stream_icon")
				If attachFromStreamIconMapping IsNot Nothing Then
					Dim attachFromStreamPage As PdfPage = attachFromStreamIconMapping.PdfRectangles(0).PdfPage
					Dim attachFromStreamIconRectangle As RectangleF = attachFromStreamIconMapping.PdfRectangles(0).Rectangle

					Dim fileStreamAttachmentWithIconPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_Stream_Icon.txt")

					attachmentStreamWithIcon = New System.IO.FileStream(fileStreamAttachmentWithIconPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)

					' Create the attachment from stream
					Dim attachFromStreamElement As New FileAttachmentElement(attachFromStreamIconRectangle, attachmentStreamWithIcon, "Attachment_Stream_Icon.txt")
					attachFromStreamElement.IconType = FileAttachmentIcon.PushPin
					attachFromStreamElement.Text = "Attachment from Stream with Pushpin Icon"
					attachFromStreamElement.IconColor = Color.Green
					attachFromStreamPage.AddElement(attachFromStreamElement)
				End If

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=File_Links_and_Attachments.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/File_Attachments.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Links_Attach/Create_Links_Atach.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Links_Attach/Create_Links_Atach.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("File_Links_and_Attachments")
				Master.SelectNode("Create_File_Links_and_Attachments")
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