Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Text_Elements_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Text_Elements.pdf"
			Try
				' The result of adding Text Elements to PDF document
				Dim addTextResult As AddElementResult = Nothing

				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				titleFont.IsUnderline = True

				' The position on X anf Y axes where to add the next element
				Dim yLocation As Single = 5
				Dim xLocation As Single = 5

				' Create a PDF page in PDF document
				Dim pdfPage As PdfPage = pdfDocument.AddPage()

				' Text Elements Using Fonts Installed in System

				' Add section title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Text Elements Using Fonts Installed in System", titleFont)
				titleTextElement.ForeColor = Color.DarkGreen
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Embed in PDF document a font with Normal style installed in system
				Dim systemFontNormal As New Font("Times New Roman", 10, GraphicsUnit.Point)
				Dim embeddedSystemFontNormal As PdfFont = pdfDocument.AddFont(systemFontNormal)

				' Add a text element using a font with Normal style installed in system
				Dim embeddedSystemFontNormalTextElement As New TextElement(xLocation, yLocation, "This text uses a font with Normal style installed in system", embeddedSystemFontNormal)
				addTextResult = pdfPage.AddElement(embeddedSystemFontNormalTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Embed in PDF document a font with Bold style installed in system
				Dim systemFontBold As New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point)
				Dim embeddedSystemFontBold As PdfFont = pdfDocument.AddFont(systemFontBold)

				' Add a text element using a font with Bold style installed in system
				Dim embeddedSystemFontBoldTextElement As New TextElement(xLocation, yLocation, "This text uses a font with Bold style installed in system", embeddedSystemFontBold)
				addTextResult = pdfPage.AddElement(embeddedSystemFontBoldTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Embed in PDF document a font with Italic style installed in system
				Dim systemFontItalic As New Font("Times New Roman", 10, FontStyle.Italic, GraphicsUnit.Point)
				Dim embeddedSystemFontItalic As PdfFont = pdfDocument.AddFont(systemFontItalic)

				' Add a text element using a font with Italic style installed in system
				Dim embeddedSystemFontItalicTextElement As New TextElement(xLocation, yLocation, "This text uses a font with Italic style installed in system", embeddedSystemFontItalic)
				addTextResult = pdfPage.AddElement(embeddedSystemFontItalicTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Text Elements Using Fonts From Local Files

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Elements Using Fonts From Local Files", titleFont)
				titleTextElement.ForeColor = Color.Navy
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Embed a True Type font from a local file in PDF document
				Dim localTrueTypeFont As PdfFont = pdfDocument.AddFont("DemoAppFiles\Input\Fonts\TrueType.ttf")

				' Add a text element using the local True Type font to PDF document
				Dim localFontTtfTextElement As New TextElement(xLocation, yLocation, "This text uses a True Type Font loaded from a local file", localTrueTypeFont)
				addTextResult = pdfPage.AddElement(localFontTtfTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom
				pdfPage = addTextResult.EndPdfPage

				' Embed an OpenType font with TrueType Outlines in PDF document
				Dim localOpenTypeTrueTypeFont As PdfFont = pdfDocument.AddFont("DemoAppFiles\Input\Fonts\OpenTypeTrueType.otf")

				' Add a text element using the local OpenType font with TrueType Outlines to PDF document
				Dim localOpenTypeTrueTypeFontTextElement As New TextElement(xLocation, yLocation, "This text uses an Open Type Font with TrueType Outlines loaded from a local file", localOpenTypeTrueTypeFont)
				addTextResult = pdfPage.AddElement(localOpenTypeTrueTypeFontTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				'  Embed an OpenType font with PostScript Outlines in PDF document
				Dim localOpenTypePostScriptFont As PdfFont = pdfDocument.AddFont("DemoAppFiles\Input\Fonts\OpenTypePostScript.otf")

				' Add a text element using the local OpenType font with PostScript Outlines to PDF document
				Dim localOpenTypePostScriptFontTextElement As New TextElement(xLocation, yLocation, "This text uses an Open Type Font with PostScript Outlines loaded from a local file", localOpenTypePostScriptFont)
				addTextResult = pdfPage.AddElement(localOpenTypePostScriptFontTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Text Elements Using Standard PDF Fonts

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Elements Using Standard PDF Fonts", titleFont)
				titleTextElement.ForeColor = Color.DarkGreen
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Create a standard PDF font with Normal style
				Dim standardPdfFontNormal As PdfFont = pdfDocument.AddFont(StdFontBaseFamily.Helvetica)
				standardPdfFontNormal.Size = 10

				' Add a text element using the standard PDF font with Normal style
				Dim standardPdfFontNormalTextElement As New TextElement(xLocation, yLocation, "This text uses a standard PDF font with Normal style", standardPdfFontNormal)
				addTextResult = pdfPage.AddElement(standardPdfFontNormalTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Create a standard PDF font with Bold style
				Dim standardPdfFontBold As PdfFont = pdfDocument.AddFont(StdFontBaseFamily.HelveticaBold)
				standardPdfFontBold.Size = 10

				' Add a text element using the standard PDF font with Bold style
				Dim standardPdfFontBoldTextElement As New TextElement(xLocation, yLocation, "This text uses a standard PDF font with Bold style", standardPdfFontBold)
				addTextResult = pdfPage.AddElement(standardPdfFontBoldTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Create a standard PDF font with Italic style
				Dim standardPdfFontItalic As PdfFont = pdfDocument.AddFont(StdFontBaseFamily.HelveticaOblique)
				standardPdfFontItalic.Size = 10

				' Add a text element using the standard PDF font with Italic style
				Dim standardPdfFontItalicTextElement As New TextElement(xLocation, yLocation, "This text uses a standard PDF font with Italic style", standardPdfFontItalic)
				addTextResult = pdfPage.AddElement(standardPdfFontItalicTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Text Elements with Vertical Text

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Vertical Text", titleFont)
				titleTextElement.ForeColor = Color.Navy
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Add a top to bottom vertical text
				Dim topBottomText As String = "This is a Top to Bottom Vertical Text"
				Dim topBottomTextWidth As Single = embeddedSystemFontNormal.GetTextWidth(topBottomText)

				Dim topBottomVerticalTextElement As New TextElement(0, 0, topBottomText, embeddedSystemFontNormal)
				topBottomVerticalTextElement.Translate(xLocation + 25, yLocation)
				topBottomVerticalTextElement.Rotate(90)
				pdfPage.AddElement(topBottomVerticalTextElement)

				' Add a bottom to top vertical text
				Dim bottomTopText As String = "This is a Bottom to Top Vertical Text"
				Dim bottomTopTextWidth As Single = embeddedSystemFontNormal.GetTextWidth(bottomTopText)

				Dim bottomTopVerticalTextElement As New TextElement(0, 0, bottomTopText, embeddedSystemFontNormal)
				bottomTopVerticalTextElement.Translate(xLocation + 125, yLocation + bottomTopTextWidth)
				bottomTopVerticalTextElement.Rotate(-90)
				pdfPage.AddElement(bottomTopVerticalTextElement)

				yLocation += bottomTopTextWidth + 10

				' Add a text element that flows freely in width and height

				Dim text As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Text_Files\Text_File.txt")

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Element that flows freely in width and height", titleFont)
				titleTextElement.ForeColor = Color.DarkGreen
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Add the text element
				Dim freeWidthAndHeightTextElement As New TextElement(xLocation, yLocation, text, embeddedSystemFontNormal)
				addTextResult = pdfPage.AddElement(freeWidthAndHeightTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Add a text element with a given width that flows freely in height

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Element with a given width that flows freely in height", titleFont)
				titleTextElement.ForeColor = Color.Navy
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Add the text element
				Dim freeHeightTextElement As New TextElement(xLocation, yLocation, 400, text, embeddedSystemFontNormal)
				addTextResult = pdfPage.AddElement(freeHeightTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Add a bounding rectangle for text element
				Dim border As New RectangleElement(addTextResult.EndPageBounds.X, addTextResult.EndPageBounds.Y, addTextResult.EndPageBounds.Width, addTextResult.EndPageBounds.Height)
				pdfPage.AddElement(border)

				' Add a text element with a given width and height

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Element with a given width and height", titleFont)
				titleTextElement.ForeColor = Color.DarkGreen
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Add the text element
				Dim boundedTextElement As New TextElement(xLocation, yLocation, 400, 50, text, embeddedSystemFontNormal)
				addTextResult = pdfPage.AddElement(boundedTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Add a bounding rectangle for text element
				border = New RectangleElement(addTextResult.EndPageBounds.X, addTextResult.EndPageBounds.Y, addTextResult.EndPageBounds.Width, addTextResult.EndPageBounds.Height)
				pdfPage.AddElement(border)

				' Add a text element that flows freely on next PDF page

				' Add section title
				xLocation -= 5
				yLocation += 10
				titleTextElement = New TextElement(xLocation, yLocation, "Text Element that flows freely on multiple PDF pages", titleFont)
				titleTextElement.ForeColor = Color.Navy
				addTextResult = pdfPage.AddElement(titleTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 10
				xLocation += 5
				pdfPage = addTextResult.EndPdfPage

				' Add the text element
				Dim multiPageText As String = System.IO.File.ReadAllText("DemoAppFiles\Input\Text_Files\Large_Text_File.txt")
				Dim multiPageTextElement As New TextElement(xLocation, yLocation, 575, multiPageText, embeddedSystemFontNormal)
				multiPageTextElement.BackColor = Color.WhiteSmoke
				addTextResult = pdfPage.AddElement(multiPageTextElement)
				yLocation = addTextResult.EndPageBounds.Bottom + 3
				pdfPage = addTextResult.EndPdfPage

				' Add a line at the bottom of the multipage text element

				Dim bottomLine As New LineElement(addTextResult.EndPageBounds.X, addTextResult.EndPageBounds.Bottom + 1, addTextResult.EndPageBounds.X + addTextResult.EndPageBounds.Width, addTextResult.EndPageBounds.Bottom + 1)
				pdfPage.AddElement(bottomLine)

				' Add a text stamp to a PDF document

				' Create a .NET font
				Dim timesNewRomanFont As New Font("Times New Roman", 24, GraphicsUnit.Point)
				' Create a PDF font
				Dim stampPdfFont As PdfFont = pdfDocument.AddFont(timesNewRomanFont, True)
				' The stamp text
				Dim stampText As String = String.Format("Text Stamp {0}", Date.Now.ToString("d"))
				' Measure the text 
				Dim textWidth As Single = stampPdfFont.GetTextWidth(stampText)
				For Each page As PdfPage In pdfDocument.Pages
					' Get the PDF page drawable area width and height
					Dim pdfPageWidth As Single = page.ClientRectangle.Width
					Dim pdfPageHeight As Single = page.ClientRectangle.Height

					' Calculate the PDF page diagonal
					Dim pdfPageDiagonal As Single = CSng(Math.Sqrt(pdfPageWidth * pdfPageWidth + pdfPageHeight * pdfPageHeight))

					' The text location on PDF page diagonal
					Dim xStampLocation As Single = (pdfPageDiagonal - textWidth) / 2

					' Create the stamp as a rotated text element
					Dim stampTextElement As New TextElement(xStampLocation, 0, stampText, stampPdfFont)
					stampTextElement.ForeColor = Color.Coral
					stampTextElement.Rotate(CSng(Math.Atan(pdfPageHeight / pdfPageWidth) * (180 / Math.PI)))
					stampTextElement.Opacity = 75

					' Add the stamp to PDF page
					page.AddElement(stampTextElement)
				Next page

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
