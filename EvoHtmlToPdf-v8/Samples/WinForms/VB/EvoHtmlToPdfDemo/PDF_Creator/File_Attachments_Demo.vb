Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class File_Attachments_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Display the attachments panel when the PDF document is opened in a PDF viewer
			pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\File_Attachments.pdf"
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
				Dim fileAttachmentPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_File.txt"
				pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File")

				' Create an attachment from a stream without icon
				Dim fileStreamAttachmentPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_Stream.txt"
				Dim attachmentStream As New System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
				pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream")

				' Add the text element
				Dim text As String = "Click the next icon to open the attachment from a file:"
				Dim textWidth As Single = subtitleFont.GetTextWidth(text)
				Dim textElement As New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				' Create an attachment from file with paperclip icon in PDF
				Dim fileAttachmentWithIconPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_File_Icon.txt"
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
				Dim fileStreamAttachmentWithIconPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_Stream_Icon.txt"
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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
