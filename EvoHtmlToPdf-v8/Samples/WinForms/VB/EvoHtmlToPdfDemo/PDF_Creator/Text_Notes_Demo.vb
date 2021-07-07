Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Text_Notes_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Text_Notes.pdf"
			Try
				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				Dim subtitleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))

				Dim xLocation As Single = 5
				Dim yLocation As Single = 5

				' Add document title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Add Text Notes to a PDF Document", titleFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Add the text element
				Dim text As String = "Click the next icon to open the the text note:"
				Dim textWidth As Single = subtitleFont.GetTextWidth(text)
				Dim textElement As New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				Dim textNoteRectangle As New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim textNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed text note")
				textNoteElement.NoteIcon = TextNoteIcon.Note
				textNoteElement.Open = False
				pdfPage.AddElement(textNoteElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "This is an already opened text note:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim textNoteOpenedElement As New TextNoteElement(textNoteRectangle, "This is an initially opened text note")
				textNoteOpenedElement.NoteIcon = TextNoteIcon.Note
				textNoteOpenedElement.Open = True
				pdfPage.AddElement(textNoteOpenedElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the the help note:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim helpNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed help note")
				helpNoteElement.NoteIcon = TextNoteIcon.Help
				helpNoteElement.Open = False
				pdfPage.AddElement(helpNoteElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "This is an already opened help note:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim helpNoteOpenedElement As New TextNoteElement(textNoteRectangle, "This is an initially opened help note")
				helpNoteOpenedElement.NoteIcon = TextNoteIcon.Help
				helpNoteOpenedElement.Open = True
				pdfPage.AddElement(helpNoteOpenedElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the comment:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim commentNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed comment note")
				commentNoteElement.NoteIcon = TextNoteIcon.Comment
				commentNoteElement.Open = False
				pdfPage.AddElement(commentNoteElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "This is an already opened comment:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim commentNoteOpenedElement As New TextNoteElement(textNoteRectangle, "This is an initially opened comment note")
				commentNoteOpenedElement.NoteIcon = TextNoteIcon.Comment
				commentNoteOpenedElement.Open = True
				pdfPage.AddElement(commentNoteOpenedElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the paragraph note: "
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim paragraphNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed paragraph note")
				paragraphNoteElement.NoteIcon = TextNoteIcon.Paragraph
				paragraphNoteElement.Open = False
				pdfPage.AddElement(paragraphNoteElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the new paragraph note:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim newParagraphNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed new paragraph note")
				newParagraphNoteElement.NoteIcon = TextNoteIcon.NewParagraph
				newParagraphNoteElement.Open = False
				pdfPage.AddElement(newParagraphNoteElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Add the text element
				text = "Click the next icon to open the key note:"
				textWidth = subtitleFont.GetTextWidth(text)
				textElement = New TextElement(xLocation, yLocation, text, subtitleFont)
				addElementResult = pdfPage.AddElement(textElement)

				textNoteRectangle = New RectangleF(xLocation + textWidth + 1, yLocation, 10, 10)

				' Create the text note
				Dim keyNoteElement As New TextNoteElement(textNoteRectangle, "This is an initially closed key note")
				keyNoteElement.NoteIcon = TextNoteIcon.Key
				keyNoteElement.Open = False
				pdfPage.AddElement(keyNoteElement)

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
