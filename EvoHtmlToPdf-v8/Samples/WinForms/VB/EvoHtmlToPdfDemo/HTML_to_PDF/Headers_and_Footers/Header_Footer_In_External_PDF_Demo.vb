Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_In_External_PDF_Demo
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

			' Set the PDF file to be inserted before conversion result
			htmlToPdfConverter.PdfDocumentOptions.AddStartDocument(pdfBeforeTextBox.Text, addHeaderFooterInInsertedPdfCheckBox.Checked, showHeaderInFirstPageCheckBox.Checked, showFooterInFirstPageCheckBox.Checked)

			' Set the PDF file to be added after conversion result
			htmlToPdfConverter.PdfDocumentOptions.AddEndDocument(pdfAfterTextBox.Text, addHeaderFooterInAppendedPdfCheckBox.Checked, True, True)

			' Enable header in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowHeader = True

			' Draw header elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowHeader Then
				DrawHeader(htmlToPdfConverter, True)
			End If

			' Enable footer in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowFooter = True

			' Draw footer elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowFooter Then
				DrawFooter(htmlToPdfConverter, True, True)
			End If

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Header_Footer_in_External_PDF.pdf"
			Try
				Dim url As String = urlTextBox.Text

				' Convert the HTML page to a PDF document and add the external PDF documents
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		''' <summary>
		''' Draw the header elements
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub DrawHeader(ByVal htmlToPdfConverter As HtmlToPdfConverter, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Header_HTML.html")

			' Set the header height in points
			htmlToPdfConverter.PdfHeaderOptions.HeaderHeight = 60

			' Set header background color
			htmlToPdfConverter.PdfHeaderOptions.HeaderBackColor = Color.White

			' Create a HTML element to be added in header
			Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

			' Set the HTML element to fit the container height
			headerHtml.FitHeight = True

			' Add HTML element to header
			htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

			If drawHeaderLine Then
				' Calculate the header width based on PDF page size and margins
				Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

				' Calculate header height
				Dim headerHeight As Single = htmlToPdfConverter.PdfHeaderOptions.HeaderHeight

				' Create a line element for the bottom of the header
				Dim headerLine As New LineElement(0, headerHeight-1, headerWidth, headerHeight-1)

				' Set line color
				headerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the header
				htmlToPdfConverter.PdfHeaderOptions.AddElement(headerLine)
			End If
		End Sub

		''' <summary>
		''' Draw the footer elements
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="addPageNumbers">A flag indicating if the page numbering is present in footer</param>
		''' <param name="drawFooterLine">A flag indicating if a line should be drawn at the top of the footer</param>
		Private Sub DrawFooter(ByVal htmlToPdfConverter As HtmlToPdfConverter, ByVal addPageNumbers As Boolean, ByVal drawFooterLine As Boolean)
			Dim footerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Footer_HTML.html")

			' Set the footer height in points
			htmlToPdfConverter.PdfFooterOptions.FooterHeight = 60

			' Set footer background color
			htmlToPdfConverter.PdfFooterOptions.FooterBackColor = Color.WhiteSmoke

			' Create a HTML element to be added in footer
			Dim footerHtml As New HtmlToPdfElement(footerHtmlUrl)

			' Set the HTML element to fit the container height
			footerHtml.FitHeight = True

			' Add HTML element to footer
			htmlToPdfConverter.PdfFooterOptions.AddElement(footerHtml)

			' Add page numbering
			If addPageNumbers Then
				' Create a text element with page numbering place holders &p; and & P;
				Dim footerText As New TextElement(0, 30, "Page &p; of &P;  ", New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))

				' Align the text at the right of the footer
				footerText.TextAlign = HorizontalTextAlign.Right

				' Set page numbering text color
				footerText.ForeColor = Color.Navy

				' Embed the text element font in PDF
				footerText.EmbedSysFont = True

				' Add the text element to footer
				htmlToPdfConverter.PdfFooterOptions.AddElement(footerText)
			End If

			If drawFooterLine Then
				' Calculate the footer width based on PDF page size and margins
				Dim footerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				htmlToPdfConverter.PdfFooterOptions.AddElement(footerLine)
			End If
		End Sub

		Private Sub Header_Footer_In_External_PDF_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfBeforeTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf"
			pdfAfterTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
