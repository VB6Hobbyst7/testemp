Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Page_Numbers_in_HTML_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Page_Numbers_in_HTML.pdf"
			Try
				' Create the document footer template
				pdfDocument.AddFooterTemplate(50)

				' ----- Add HTML with Page Numbering to Footer -----

				' Create a variable HTML element with page numbering
				Dim htmlStringWithPageNumbers As String = htmlWithPageNumbersTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text
				Dim footerHtmlWithPageNumbers As New HtmlToPdfVariableElement(htmlStringWithPageNumbers, baseUrl)

				' Set the HTML element to fit the container height
				footerHtmlWithPageNumbers.FitHeight = True

				' Add variable HTML element with page numbering to footer
				pdfDocument.Footer.AddElement(footerHtmlWithPageNumbers)

				' Optionally draw a line at the top of the footer
				If drawFooterLineCheckBox.Checked Then
					Dim footerWidth As Single = pdfDocument.Footer.Width

					' Create a line element for the top of the footer
					Dim footerLine As New LineElement(0, 0, footerWidth, 0)

					' Set line color
					footerLine.ForeColor = Color.Gray

					' Add line element to the bottom of the footer
					pdfDocument.Footer.AddElement(footerLine)
				End If

				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(0, 0, urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Optionally add a space between footer and the page body
				' Leave this option not set for no spacing
				htmlToPdfElement.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

				' Add the HTML to PDF element to document
				' This will raise the PrepareRenderPdfPageEvent event where the header and footer visibilit per page can be changed
				pdfPage.AddElement(htmlToPdfElement)

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
