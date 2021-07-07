Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Getting_Started_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
			htmlToPdfConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

			' Set HTML viewer height in pixels to convert the top part of a HTML page 
			' Leave it not set to convert the entire HTML
			If htmlViewerHeightTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
			End If

			' Set PDF page size which can be a predefined size like A4 or a custom size in points 
			' Leave it not set to have a default A4 PDF page
			htmlToPdfConverter.PdfDocumentOptions.PdfPageSize = SelectedPdfPageSize()

			' Set PDF page orientation to Portrait or Landscape
			' Leave it not set to have a default Portrait orientation for PDF page
			htmlToPdfConverter.PdfDocumentOptions.PdfPageOrientation = SelectedPdfPageOrientation()

			' Set the maximum time in seconds to wait for HTML page to be loaded 
			' Leave it not set for a default 60 seconds maximum wait time
			htmlToPdfConverter.NavigationTimeout = Integer.Parse(navigationTimeoutTextBox.Text)

			' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
			' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
			If conversionDelayTextBox.Text.Length > 0 Then
				htmlToPdfConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Getting_Started.pdf"
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

		Private Sub Getting_Started_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfPageSizeComboBox.SelectedItem = "A4"
			pdfPageOrientationComboBox.SelectedItem = "Portrait"

			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Function SelectedPdfPageSize() As PdfPageSize
			Select Case pdfPageSizeComboBox.SelectedItem.ToString()
				Case "A0"
					Return PdfPageSize.A0
				Case "A1"
					Return PdfPageSize.A1
				Case "A10"
					Return PdfPageSize.A10
				Case "A2"
					Return PdfPageSize.A2
				Case "A3"
					Return PdfPageSize.A3
				Case "A4"
					Return PdfPageSize.A4
				Case "A5"
					Return PdfPageSize.A5
				Case "A6"
					Return PdfPageSize.A6
				Case "A7"
					Return PdfPageSize.A7
				Case "A8"
					Return PdfPageSize.A8
				Case "A9"
					Return PdfPageSize.A9
				Case "ArchA"
					Return PdfPageSize.ArchA
				Case "ArchB"
					Return PdfPageSize.ArchB
				Case "ArchC"
					Return PdfPageSize.ArchC
				Case "ArchD"
					Return PdfPageSize.ArchD
				Case "ArchE"
					Return PdfPageSize.ArchE
				Case "B0"
					Return PdfPageSize.B0
				Case "B1"
					Return PdfPageSize.B1
				Case "B2"
					Return PdfPageSize.B2
				Case "B3"
					Return PdfPageSize.B3
				Case "B4"
					Return PdfPageSize.B4
				Case "B5"
					Return PdfPageSize.B5
				Case "Flsa"
					Return PdfPageSize.Flsa
				Case "HalfLetter"
					Return PdfPageSize.HalfLetter
				Case "Ledger"
					Return PdfPageSize.Ledger
				Case "Legal"
					Return PdfPageSize.Legal
				Case "Letter"
					Return PdfPageSize.Letter
				Case "Letter11x17"
					Return PdfPageSize.Letter11x17
				Case "Note"
					Return PdfPageSize.Note
				Case Else
					Return PdfPageSize.A4
			End Select
		End Function

		Private Function SelectedPdfPageOrientation() As PdfPageOrientation
			Return If(pdfPageOrientationComboBox.SelectedItem.ToString() = "Portrait", PdfPageOrientation.Portrait, PdfPageOrientation.Landscape)
		End Function

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub
	End Class
End Namespace
