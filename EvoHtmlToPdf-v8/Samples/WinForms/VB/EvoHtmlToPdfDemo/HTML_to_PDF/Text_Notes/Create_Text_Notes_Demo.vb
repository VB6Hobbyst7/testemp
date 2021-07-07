Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes
	Partial Public Class Create_Text_Notes_Demo
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
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Text_Notes.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				Dim htmlWithLinksAndAttachMarkers As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with markers for file links and attachments to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithLinksAndAttachMarkers, baseUrl)

				' Make the HTML element with 'text_note' mapping ID a text note
				Dim textNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("text_note")
				If textNoteMapping IsNot Nothing Then
					Dim textNotePage As PdfPage = textNoteMapping.PdfRectangles(0).PdfPage
					Dim textNoteRectangle As RectangleF = textNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim textNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed text note")
					textNoteElement.NoteIcon = TextNoteIcon.Note
					textNoteElement.Open = False
					textNotePage.AddElement(textNoteElement)
				End If

				' Make the HTML element with 'text_note_opened' mapping ID an initially opened text note
				Dim textNoteOpenedMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("text_note_opened")
				If textNoteOpenedMapping IsNot Nothing Then
					Dim textNoteOpenedPage As PdfPage = textNoteOpenedMapping.PdfRectangles(0).PdfPage
					Dim textNoteOpenedRectangle As RectangleF = textNoteOpenedMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim textNoteOpenedElement As New TextNoteElement(textNoteOpenedRectangle, "This is an initially opened text note")
					textNoteOpenedElement.NoteIcon = TextNoteIcon.Note
					textNoteOpenedElement.Open = True
					textNoteOpenedPage.AddElement(textNoteOpenedElement)
				End If

				' Make the HTML element with 'help_note' mapping ID a help note
				Dim helpNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("help_note")
				If helpNoteMapping IsNot Nothing Then
					Dim helpNotePage As PdfPage = helpNoteMapping.PdfRectangles(0).PdfPage
					Dim helpNoteRectangle As RectangleF = helpNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim helpNoteElement As New TextNoteElement(helpNoteRectangle, "This is an initially closed help note")
					helpNoteElement.NoteIcon = TextNoteIcon.Help
					helpNoteElement.Open = False
					helpNotePage.AddElement(helpNoteElement)
				End If

				' Make the HTML element with 'help_note_opened' mapping ID an initially opened help note
				Dim helpNoteOpenedMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("help_note_opened")
				If helpNoteOpenedMapping IsNot Nothing Then
					Dim helpNoteOpenedPage As PdfPage = helpNoteOpenedMapping.PdfRectangles(0).PdfPage
					Dim helpNoteOpenedRectangle As RectangleF = helpNoteOpenedMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim helpNoteOpenedElement As New TextNoteElement(helpNoteOpenedRectangle, "This is an initially opened help note")
					helpNoteOpenedElement.NoteIcon = TextNoteIcon.Help
					helpNoteOpenedElement.Open = True
					helpNoteOpenedPage.AddElement(helpNoteOpenedElement)
				End If

				' Make the HTML element with 'comment_note' mapping ID a comment note
				Dim commentNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("comment_note")
				If commentNoteMapping IsNot Nothing Then
					Dim commentNotePage As PdfPage = commentNoteMapping.PdfRectangles(0).PdfPage
					Dim commentNoteRectangle As RectangleF = commentNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim commentNoteElement As New TextNoteElement(commentNoteRectangle, "This is an initially closed comment note")
					commentNoteElement.NoteIcon = TextNoteIcon.Comment
					commentNoteElement.Open = False
					commentNotePage.AddElement(commentNoteElement)
				End If

				' Make the HTML element with 'comment_note_opened' mapping ID an initially opened comment note
				Dim commentNoteOpenedMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("comment_note_opened")
				If commentNoteOpenedMapping IsNot Nothing Then
					Dim commentNoteOpenedPage As PdfPage = commentNoteOpenedMapping.PdfRectangles(0).PdfPage
					Dim commentNoteOpenedRectangle As RectangleF = commentNoteOpenedMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim commentNoteOpenedElement As New TextNoteElement(commentNoteOpenedRectangle, "This is an initially opened comment note")
					commentNoteOpenedElement.NoteIcon = TextNoteIcon.Comment
					commentNoteOpenedElement.Open = True
					commentNoteOpenedPage.AddElement(commentNoteOpenedElement)
				End If

				' Make the HTML element with 'paragraph_note' mapping ID a paragraph note
				Dim paragraphNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("paragraph_note")
				If paragraphNoteMapping IsNot Nothing Then
					Dim paragraphNotePage As PdfPage = paragraphNoteMapping.PdfRectangles(0).PdfPage
					Dim paragraphNoteRectangle As RectangleF = paragraphNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim paragraphNoteElement As New TextNoteElement(paragraphNoteRectangle, "This is an initially closed paragraph note")
					paragraphNoteElement.NoteIcon = TextNoteIcon.Paragraph
					paragraphNoteElement.Open = False
					paragraphNotePage.AddElement(paragraphNoteElement)
				End If

				' Make the HTML element with 'new_paragraph_note' mapping ID a new paragraph note
				Dim newParagraphNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("new_paragraph_note")
				If newParagraphNoteMapping IsNot Nothing Then
					Dim newParagraphNotePage As PdfPage = newParagraphNoteMapping.PdfRectangles(0).PdfPage
					Dim newParagraphNoteRectangle As RectangleF = newParagraphNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim newParagraphNoteElement As New TextNoteElement(newParagraphNoteRectangle, "This is an initially closed new paragraph note")
					newParagraphNoteElement.NoteIcon = TextNoteIcon.NewParagraph
					newParagraphNoteElement.Open = False
					newParagraphNotePage.AddElement(newParagraphNoteElement)
				End If

				' Make the HTML element with 'key_note' mapping ID a key note
				Dim keyNoteMapping As HtmlElementMapping = htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("key_note")
				If keyNoteMapping IsNot Nothing Then
					Dim keyNotePage As PdfPage = keyNoteMapping.PdfRectangles(0).PdfPage
					Dim keyNoteRectangle As RectangleF = keyNoteMapping.PdfRectangles(0).Rectangle

					' Create the text note
					Dim keyNoteElement As New TextNoteElement(keyNoteRectangle, "This is an initially closed key note")
					keyNoteElement.NoteIcon = TextNoteIcon.Key
					keyNoteElement.Open = False
					keyNotePage.AddElement(keyNoteElement)
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

		Private Sub Create_Text_Notes_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Text_Notes.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
