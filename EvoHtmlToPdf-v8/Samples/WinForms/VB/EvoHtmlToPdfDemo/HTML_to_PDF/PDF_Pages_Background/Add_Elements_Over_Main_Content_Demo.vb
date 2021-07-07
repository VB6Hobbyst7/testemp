Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
	Partial Public Class Add_Elements_Over_Main_Content_Demo
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

			' Set a handler for AfterRenderPdfPageEvent where to add the stamp in each PDF page over the main content
			AddHandler htmlToPdfConverter.AfterRenderPdfPageEvent, AddressOf htmlToPdfConverter_AfterRenderPdfPageEvent

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Add_Elements_Over_Main_Content.pdf"
			Try
				If convertUrlRadioButton.Checked Then
					Dim url As String = urlTextBox.Text

					' Convert the HTML page given by an URL to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				Else
					Dim htmlString As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with a base URL to a PDF document in a memory buffer
					Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertHtml(htmlString, baseUrl)

					' Write the memory buffer in a PDF file
					System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
				End If
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow

				' Uninstall the handler
				RemoveHandler htmlToPdfConverter.AfterRenderPdfPageEvent, AddressOf htmlToPdfConverter_AfterRenderPdfPageEvent
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub htmlToPdfConverter_AfterRenderPdfPageEvent(ByVal eventParams As AfterRenderPdfPageParams)
			If Not addStampCheckBox.Checked Then
				Return
			End If

			' Get the rendered PDF page
			Dim pdfPage As PdfPage = eventParams.Page

			Dim pageNumber As Integer = eventParams.PageNumber
			Dim pageCount As Integer = eventParams.PageCount
			Dim isOddPage As Boolean = pageNumber Mod 2 <> 0

			' Get the PDF document
			Dim pdfDocument As Document = pdfPage.Document

			' Get the PDF page drawable area width and height
			Dim pdfPageWidth As Single = pdfPage.ClientRectangle.Width
			Dim pdfPageHeight As Single = pdfPage.ClientRectangle.Height

			' Create a .NET font
			Dim timesNewRomanFont As New Font("Times New Roman", 50, GraphicsUnit.Point)

			' Create a PDF font
			Dim pdfFont As PdfFont = pdfDocument.AddFont(timesNewRomanFont, True)

			' The stamp text
			Dim text As String = String.Format("Stamp on Page {0} of {1}", pageNumber, pageCount)

			' Measure the text 
			Dim textWidth As Single = pdfFont.GetTextWidth(text)

			' Calculate the PDF page diagonal
			Dim pdfPageDiagonal As Single = CSng(Math.Sqrt(pdfPageWidth*pdfPageWidth + pdfPageHeight*pdfPageHeight))

			' The text location on PDF page diagonal
			Dim xLocation As Single = (pdfPageDiagonal - textWidth) / 2

			' Create the stamp as a rotated text element
			Dim stampTextElement As New TextElement(xLocation, 0, text, pdfFont)
			stampTextElement.ForeColor = If(isOddPage, Color.Blue, Color.Green)
			stampTextElement.Rotate(CSng(Math.Atan(pdfPageHeight / pdfPageWidth) * (180 / Math.PI)))
			stampTextElement.Opacity = 75

			' Add the stamp to PDF page
			pdfPage.AddElement(stampTextElement)
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
