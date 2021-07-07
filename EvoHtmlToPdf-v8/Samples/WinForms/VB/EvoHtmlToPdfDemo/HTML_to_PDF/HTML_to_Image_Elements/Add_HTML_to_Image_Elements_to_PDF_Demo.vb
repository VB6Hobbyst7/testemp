Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements
	Partial Public Class Add_HTML_to_Image_Elements_to_PDF_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Create a PDF page where to add the first HTML
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Add_HTML_to_Image_Elements_to_PDF.pdf"
			Try
				' The image location in PDF
				Dim xLocation As Single = Single.Parse(xLocationTextBox.Text)
				Dim yLocation As Single = Single.Parse(yLocationTextBox.Text)

				' The URL of the HTML page to convert to an image in PDF
				Dim urlToConvert As String = urlTextBox.Text

				' Create the HTML to Image element
				Dim htmlToImageElement As New HtmlToImageElement(xLocation, yLocation, urlToConvert)

				' Optionally set the HTML viewer width
				htmlToImageElement.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

				' Optionally set the HTML viewer height
				If htmlViewerHeightTextBox.Text.Length > 0 Then
					htmlToImageElement.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
				End If

				' Optionally set the HTML content clipping option to force the HTML content width to be exactly HtmlViewerWidth pixels
				htmlToImageElement.ClipHtmlView = clipContentCheckBox.Checked

				' Optionally set the destination width in PDF
				If contentWidthTextBox.Text.Length > 0 Then
					htmlToImageElement.Width = Single.Parse(contentWidthTextBox.Text)
				End If

				' Optionally set the destination height in PDF
				If contentHeightTextBox.Text.Length > 0 Then
					htmlToImageElement.Height = Single.Parse(contentHeightTextBox.Text)
				End If

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToImageElement.ConversionDelay = 2

				' Add the HTML to Image element to PDF document
				' The AddElementResult contains the bounds of the HTML to Image Element in last rendered PDF page
				' such that you can start a new PDF element right under it
				Dim result As AddElementResult = firstPdfPage.AddElement(htmlToImageElement)

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
