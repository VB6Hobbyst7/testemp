Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_Multiple_HTML_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create the PDF document where to add the HTML documents
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Create a PDF page where to add the first HTML
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Merge_Multipe_HTML.pdf"
			Try
				' Create the first HTML to PDF element
				Dim firstHtml As New HtmlToPdfElement(0, 0, firstUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				firstHtml.ConversionDelay = 2

				' Add the first HTML to PDF document
				Dim firstAddResult As AddElementResult = firstPdfPage.AddElement(firstHtml)

				Dim secondPdfPage As PdfPage = Nothing
				Dim secondHtmlLocation As PointF = Point.Empty

				If startNewPageCheckBox.Checked Then
					' Create a PDF page where to add the second HTML
					secondPdfPage = pdfDocument.AddPage()
					secondHtmlLocation = PointF.Empty
				Else
					' Add the second HTML on the PDF page where the first HTML ended
					secondPdfPage = firstAddResult.EndPdfPage
					secondHtmlLocation = New PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom)
				End If

				' Create the second HTML to PDF element
				Dim secondHtml As New HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				secondHtml.ConversionDelay = 2

				' Add the second HTML to PDF document
				secondPdfPage.AddElement(secondHtml)

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
