Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps
	Partial Public Class Add_Watermarks_Stamps_Demo
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

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Watermarks_and_Stamps.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML page to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				' Get the stamp width and height
				Dim stampWidth As Single = Single.Parse(stampWidthTextBox.Text)
				Dim stampHeight As Single = Single.Parse(stampHeightTextBox.Text)

				' Center the stamp at the top of PDF page
				Dim stampXLocation As Single = (pdfDocument.Pages(0).ClientRectangle.Width - stampWidth) / 2
				Dim stampYLocation As Single = 0

				Dim stampRectangle As New RectangleF(stampXLocation, stampYLocation, stampWidth, stampHeight)

				' Create the stamp template to be repeated in each PDF page
				Dim stampTemplate As Template = pdfDocument.AddTemplate(stampRectangle)

				' Create the HTML element to add in stamp template
				Dim stampHtmlElement As New HtmlToPdfElement(htmlStringTextBox.Text, baseUrlTextBox.Text)

				' Set the HTML viewer width for the HTML added in stamp
				stampHtmlElement.HtmlViewerWidth = 600
				' Fit the HTML content in stamp template
				stampHtmlElement.FitWidth = True
				stampHtmlElement.FitHeight = True

				' Add HTML to stamp template
				stampTemplate.AddElement(stampHtmlElement)

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

		Private Sub Add_Watermarks_Stamps_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Watermark_Stamp.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
