Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class URI_Links_Demo
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
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\URI_Links.pdf"
			Try
				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				Dim subtitleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))

				' The links text font
				Dim linkTextFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Bold, GraphicsUnit.Point))
				linkTextFont.IsUnderline = True

				Dim xLocation As Single = 5
				Dim yLocation As Single = 5

				' Add document title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Create URI Links in PDF Document", titleFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Make a text in PDF a link to a web page

				' Add the text element
				Dim text As String = "Click this text to open a web page!"
				Dim textWidth As Single = linkTextFont.GetTextWidth(text)
				Dim linkTextElement As New TextElement(xLocation, yLocation, text, linkTextFont)
				linkTextElement.ForeColor = Color.Navy
				addElementResult = pdfPage.AddElement(linkTextElement)

				' Create the URI link element having the size of the text element
				Dim linkRectangle As New RectangleF(xLocation, yLocation, textWidth, addElementResult.EndPageBounds.Height)
				Dim url As String = "http://www.evopdf.com"
				Dim uriLink As New LinkUrlElement(linkRectangle, url)

				' Add the URI link to PDF document
				pdfPage.AddElement(uriLink)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Make an image in PDF a link to a web page

				Dim subtitleTextElement As New TextElement(xLocation, yLocation, "Click the image below to open a web page:", subtitleFont)
				addElementResult = pdfPage.AddElement(subtitleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 5

				' Add the image element
				Dim linkImageElement As New ImageElement(xLocation, yLocation, 120, "DemoAppFiles\Input\Images\logo.jpg")
				addElementResult = pdfPage.AddElement(linkImageElement)

				' Create the URI link element having the size of the image element
				linkRectangle = addElementResult.EndPageBounds
				uriLink = New LinkUrlElement(linkRectangle, url)

				' Add the URI link to PDF document
				pdfPage.AddElement(uriLink)

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
