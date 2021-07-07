Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Text_Notes
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

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

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Text_Notes.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Text_Notes.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Text_Notes.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("PDF_Creator_Text_Notes")
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