Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
	Partial Public Class Select_in_API_Elements_to_Retrieve_Demo
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

			' Select the HTML elements for which to retrieve location and other information from HTML document
			htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { htmlElementsSelectorTextBox.Text }

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Select_in_API_HTML_Elements_to_Retrieve.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert HTML page to a PDF document object which can be further modified to highlight the selected elements
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				' Highlight the selected elements in PDF with colored rectangles
				For Each htmlElementInfo As HtmlElementMapping In htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					' Get other information about HTML element
					Dim htmlElementTagName As String = htmlElementInfo.HtmlElementTagName
					Dim htmlElementID As String = htmlElementInfo.HtmlElementId

					' Hightlight the HTML element in PDF

					' A HTML element can span over many PDF pages and therefore the mapping of the HTML element in PDF document consists 
					' in a list of rectangles, one rectangle for each PDF page where this element was rendered
					For Each htmlElementLocationInPdf As HtmlElementPdfRectangle In htmlElementInfo.PdfRectangles
						' Get the HTML element location in PDF page
						Dim htmlElementPdfPage As PdfPage = htmlElementLocationInPdf.PdfPage
						Dim htmlElementRectangleInPdfPage As RectangleF = htmlElementLocationInPdf.Rectangle

						' Highlight the HTML element element with a colored rectangle in PDF
						Dim highlightRectangle As New RectangleElement(htmlElementRectangleInPdfPage.X, htmlElementRectangleInPdfPage.Y, htmlElementRectangleInPdfPage.Width, htmlElementRectangleInPdfPage.Height)

						If htmlElementTagName.ToLower() = "h1" Then
							highlightRectangle.ForeColor = Color.Blue
						ElseIf htmlElementTagName.ToLower() = "h2" Then
							highlightRectangle.ForeColor = Color.Green
						ElseIf htmlElementTagName.ToLower() = "h3" Then
							highlightRectangle.ForeColor = Color.Red
						ElseIf htmlElementTagName.ToLower() = "h4" Then
							highlightRectangle.ForeColor = Color.Yellow
						ElseIf htmlElementTagName.ToLower() = "h5" Then
							highlightRectangle.ForeColor = Color.Indigo
						ElseIf htmlElementTagName.ToLower() = "h6" Then
							highlightRectangle.ForeColor = Color.Orange
						Else
							highlightRectangle.ForeColor = Color.Navy
						End If

						highlightRectangle.LineStyle.LineDashStyle = LineDashStyle.Solid

						htmlElementPdfPage.AddElement(highlightRectangle)
					Next htmlElementLocationInPdf
				Next htmlElementInfo

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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
