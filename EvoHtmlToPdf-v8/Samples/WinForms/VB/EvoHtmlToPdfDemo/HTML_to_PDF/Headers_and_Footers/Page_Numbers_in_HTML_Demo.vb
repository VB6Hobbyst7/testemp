Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Page_Numbers_in_HTML_Demo
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

			' Enable footer in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowFooter = True

			' Optionally add a space between footer and the page body
			' Leave this option not set for no spacing
			htmlToPdfConverter.PdfDocumentOptions.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

			' Set the footer height in points
			htmlToPdfConverter.PdfFooterOptions.FooterHeight = 50

			' ----- Add HTML with Page Numbering to Footer -----

			' Create a variable HTML element with page numbering
			Dim htmlStringWithPageNumbers As String = htmlWithPageNumbersTextBox.Text
			Dim baseUrl As String = baseUrlTextBox.Text
			Dim footerHtmlWithPageNumbers As New HtmlToPdfVariableElement(htmlStringWithPageNumbers, baseUrl)

			' Set the HTML element to fit the container height
			footerHtmlWithPageNumbers.FitHeight = True

			' Add variable HTML element with page numbering to footer
			htmlToPdfConverter.PdfFooterOptions.AddElement(footerHtmlWithPageNumbers)

			' Optionally draw a line at the top of the footer
			If drawFooterLineCheckBox.Checked Then
				' Calculate the footer width based on PDF page size and margins
				Dim footerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				htmlToPdfConverter.PdfFooterOptions.AddElement(footerLine)
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Page_Numbers_in_HTML.pdf"
			Try
				' Convert the HTML page to a PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

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

		Private Sub Page_Numbers_in_HTML_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim htmlWithPageNumbers As String = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Page_Numbers_in_HTML.html")

			htmlWithPageNumbersTextBox.Text = htmlWithPageNumbers
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
