Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Create_PDF_Documents_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Get the PDF Standard
			' By default the Full PDF standard is used
			Dim pdfStandard As PdfStandardSubset = PdfStandardSubset.Full
			If pdfARadioButton.Checked Then
				pdfStandard = PdfStandardSubset.Pdf_A_1b
			ElseIf pdfXRadioButton.Checked Then
				pdfStandard = PdfStandardSubset.Pdf_X_1a
			End If

			' Get the Color Space
			' By default the RGB color space is used
			Dim pdfColorSpace As ColorSpace = ColorSpace.RGB
			If grayScaleRadioButton.Checked Then
				pdfColorSpace = ColorSpace.Gray
			ElseIf cmykRadioButton.Checked Then
				pdfColorSpace = ColorSpace.CMYK
			End If

			' Create the PDF document
			Dim pdfDocument As Document = Nothing

            If pdfStandard = PdfStandardSubset.Full AndAlso pdfColorSpace = ColorSpace.RGB Then
                ' Create a PDF document with default standard and color space
                pdfDocument = New Document()
            Else
                ' Create a PDF document with the selected standard and color space
                pdfDocument = New Document(pdfStandard, pdfColorSpace)
            End If

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Get the selected PDF page size
			Dim pdfPageSize As PdfPageSize = SelectedPdfPageSize()

			' Get the selected PDF page orientation
			Dim pdfPageOrientation As PdfPageOrientation = SelectedPdfPageOrientation()

			' Get the PDF page margins
			Dim pdfPageMargins As New Margins(Single.Parse(leftMarginTextBox.Text), Single.Parse(rightMarginTextBox.Text), Single.Parse(topMarginTextBox.Text), Single.Parse(bottomMarginTextBox.Text))

			' Create a PDF page in PDF document
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage(pdfPageSize, pdfPageMargins, pdfPageOrientation)

			Cursor = Cursors.WaitCursor

			' The output PDF file
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Create_PDF_Documents.pdf"
			Try
				' The URL of the HTML page to convert to PDF
				Dim urlToConvert As String = "http://www.evopdf.com"

				' Create the HTML to PDF element
				Dim htmlToPdfElement As New HtmlToPdfElement(urlToConvert)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to PDF document
				firstPdfPage.AddElement(htmlToPdfElement)

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

		Private Sub Create_PDF_Documents_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfPageSizeComboBox.SelectedItem = "A4"
			pdfPageOrientationComboBox.SelectedItem = "Portrait"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
