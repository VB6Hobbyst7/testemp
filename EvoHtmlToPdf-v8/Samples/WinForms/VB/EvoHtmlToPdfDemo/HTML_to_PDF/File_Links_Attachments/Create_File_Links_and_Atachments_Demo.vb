Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments
	Partial Public Class Create_File_Links_and_Atachments_Demo
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

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\File_Links_and_Attachments.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				Dim htmlWithLinksAndAttachMarkers As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with markers for file links and attachments to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithLinksAndAttachMarkers, baseUrl)

				' Display the attachments panel when the PDF document is opened in a PDF viewer
				pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseAttachments

				' Create File Links

				' Make the HTML element with 'file_link_text' mapping ID a link to an external file
				Dim fileLinkTextMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("file_link_text")
				If fileLinkTextMapping IsNot Nothing Then
					Dim fileLinkTextPage As PdfPage = fileLinkTextMapping.PdfRectangles(0).PdfPage
					Dim fileLinkTextRectangle As RectangleF = fileLinkTextMapping.PdfRectangles(0).Rectangle

					Dim filePath As String = "..\..\Input\Linked_Files\Linked_External_File.txt"

					' Create the file link
					Dim fileLinkTextElement As New FileLinkElement(fileLinkTextRectangle, filePath)
					fileLinkTextPage.AddElement(fileLinkTextElement)
				End If

				' Make the HTML element with 'file_link_img' ID a link to an external file
				Dim fileLinkImgMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("file_link_image")
				If fileLinkImgMapping IsNot Nothing Then
					Dim fileLinkImgPage As PdfPage = fileLinkImgMapping.PdfRectangles(0).PdfPage
					Dim fileLinkImgRectangle As RectangleF = fileLinkImgMapping.PdfRectangles(0).Rectangle

					Dim filePath As String = "..\..\Input\Linked_Files\Linked_External_File.txt"

					' Create the file link
					Dim fileLinkImgElement As New FileLinkElement(fileLinkImgRectangle, filePath)
					fileLinkImgPage.AddElement(fileLinkImgElement)
				End If

				' Create File Attachments

				' Create an attachment from a file without icon
				Dim fileAttachmentPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_File.txt"
				pdfDocument.AddFileAttachment(fileAttachmentPath, "Attachment from File")

				' Create an attachment from a stream without icon
				Dim fileStreamAttachmentPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_Stream.txt"
				Dim attachmentStream As New System.IO.FileStream(fileStreamAttachmentPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
				pdfDocument.AddFileAttachment(attachmentStream, "Attachment_Stream.txt", "Attachment from Stream")

				' Create an attachment from file with paperclip icon in PDF
				Dim attachFromFileIconMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("attach_from_file_icon")
				If attachFromFileIconMapping IsNot Nothing Then
					Dim attachFromFilePage As PdfPage = attachFromFileIconMapping.PdfRectangles(0).PdfPage
					Dim attachFromFileIconRectangle As RectangleF = attachFromFileIconMapping.PdfRectangles(0).Rectangle

					Dim fileAttachmentWithIconPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_File_Icon.txt"

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

					Dim fileStreamAttachmentWithIconPath As String = "DemoAppFiles\Input\Attach_Files\Attachment_Stream_Icon.txt"

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

		Private Sub Add_File_Links_and_Atachments_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\File_Links_and_Attachments.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
