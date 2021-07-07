Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
	Partial Public Class Replace_with_Higher_Quality_Images_Demo
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

			' Select all images from HTML page
			htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { "img" }

			' Exclude the original images from rendering becuase they will be replaced by an image from local file system
			htmlToPdfConverter.HiddenHtmlElementsSelectors = New String() { "img" }

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Replace_with_Higher_Quality_Images.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML string with images to replace to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				' Replace the images selected in HTML using special attributes with images from local file system
				For Each imageElementInfo As HtmlElementMapping In htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					Dim imagePdfPage As PdfPage = imageElementInfo.PdfRectangles(0).PdfPage
					Dim imageRectangle As RectangleF = imageElementInfo.PdfRectangles(0).Rectangle

					Dim newImageElement As New ImageElement(imageRectangle.X, imageRectangle.Y, imageRectangle.Width, imageRectangle.Height, "DemoAppFiles\Input\Images\box.jpg")
					newImageElement.EnlargeEnabled = True
					imagePdfPage.AddElement(newImageElement)
				Next imageElementInfo

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

		Private Sub viewHtmlLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles viewHtmlLinkLabel.LinkClicked
			Process.Start(urlTextBox.Text)
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
