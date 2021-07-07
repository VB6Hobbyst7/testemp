Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class File_Attachments
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Display the attachments panel when the PDF document is opened in a PDF viewer
			pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				Dim subtitleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))

				Dim xLocation As Single = 5
				Dim yLocation As Single = 5

				' Add document title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Attach Files and Streams to a PDF Document", titleFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Create an attachment from a file without icon
				Dim fileAttachmentPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_File.txt")
				pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File")

				' Create an attachment from a stream without icon
				Dim fileStreamAttachmentPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_Stream.txt")
				Dim attachmentStream As New System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
				pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream")

				' Add the text element
				Dim text As String = "Click the next icon to open the attachment from a file:"
				Dim textWidth As Single = subtitleFont.GetTextWidth(text)
				Dim textElement As New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				' Create an attachment from file with paperclip icon in PDF
				Dim fileAttachmentWithIconPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_File_Icon.txt")
				' Create the attachment from file
				Dim attachFromFileIconRectangle As New RectangleF(xLocation + textWidth + 3, yLocation, 6, 10)
				Dim attachFromFileElement As New FileAttachmentElement(attachFromFileIconRectangle, fileAttachmentWithIconPath)
				attachFromFileElement.IconType = FileAttachmentIcon.Paperclip
				attachFromFileElement.Text = "Attachment from File with Paperclip Icon"
				attachFromFileElement.IconColor = Color.Blue
				pdfPage.AddElement(attachFromFileElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the attachment from a stream:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				' Create an attachment from stream with pushpin icon in PDF
				Dim fileStreamAttachmentWithIconPath As String = Server.MapPath("~/DemoAppFiles/Input/Attach_Files/Attachment_Stream_Icon.txt")
				Dim attachmentStreamWithIcon As New System.IO.FileStream(fileStreamAttachmentWithIconPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
				' Create the attachment from stream
				Dim attachFromStreamIconRectangle As New RectangleF(xLocation + textWidth + 3, yLocation, 6, 10)
				Dim attachFromStreamElement As New FileAttachmentElement(attachFromStreamIconRectangle, attachmentStreamWithIcon, "Attachment_Stream_Icon.txt")
				attachFromStreamElement.IconType = FileAttachmentIcon.PushPin
				attachFromStreamElement.Text = "Attachment from Stream with Pushpin Icon"
				attachFromStreamElement.IconColor = Color.Green
				pdfPage.AddElement(attachFromStreamElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=File_Attachments.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/File_Attachments.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/File_Attachments.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("File_Attachments")
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