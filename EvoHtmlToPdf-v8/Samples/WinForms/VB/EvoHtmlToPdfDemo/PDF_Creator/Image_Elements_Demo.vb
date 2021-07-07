Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Image_Elements_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Image_Elements.pdf"
			Try
				' The result of adding elements to PDF document
				Dim addElementResult As AddElementResult = Nothing

				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point))
				Dim subtitleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Bold, GraphicsUnit.Point))

				' The position on X anf Y axes where to add the next element
				Dim yLocation As Single = 5
				Dim xLocation As Single = 5

				' Create a PDF page in PDF document
				Dim pdfPage As PdfPage = pdfDocument.AddPage()

				' Add section title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Images Scaling", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				pdfPage = addElementResult.EndPdfPage

				Dim titlesYLocation As Single = yLocation

				' Add an unscaled image

				' Add section title
				Dim subtitleTextElement As New TextElement(xLocation, titlesYLocation, "Unscaled small image with normal resolution", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				addElementResult = pdfPage.AddElement(subtitleTextElement)

				pdfPage = addElementResult.EndPdfPage
				Dim imagesYLocation As Single = addElementResult.EndPageBounds.Bottom + 10

				Dim imagePath As String = "DemoAppFiles\Input\Images\picture_small.jpg"
				Dim unscaledImageElement As New ImageElement(xLocation, imagesYLocation, imagePath)
				addElementResult = pdfPage.AddElement(unscaledImageElement)

				Dim scaledDownImageRectangle As New RectangleF(addElementResult.EndPageBounds.Right + 30, addElementResult.EndPageBounds.Y, addElementResult.EndPageBounds.Width, addElementResult.EndPageBounds.Height)

				' Add a large image scaled down to same size in PDF

				' Add section title
				subtitleTextElement = New TextElement(scaledDownImageRectangle.X, titlesYLocation, "Scaled down large image has higher resolution", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				pdfPage.AddElement(subtitleTextElement)

				imagePath = "DemoAppFiles\Input\Images\picture_large.jpg"
				Dim scaledDownImageElement As New ImageElement(scaledDownImageRectangle.X, scaledDownImageRectangle.Y, scaledDownImageRectangle.Width, imagePath)
				Dim scaledDownImageResult As AddElementResult = pdfPage.AddElement(scaledDownImageElement)

				' Add a border around the scaled down image
				Dim borderElement As New RectangleElement(scaledDownImageRectangle)
				pdfPage.AddElement(borderElement)

				' Add an unscaled small image

				Dim columnX As Single = scaledDownImageResult.EndPageBounds.Right + 30

				' Add section title
				subtitleTextElement = New TextElement(columnX, titlesYLocation, "Unscaled small image", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				pdfPage.AddElement(subtitleTextElement)

				imagePath = "DemoAppFiles\Input\Images\picture_smaller.jpg"
				unscaledImageElement = New ImageElement(columnX, imagesYLocation, imagePath)
				Dim unscaledImageResult As AddElementResult = pdfPage.AddElement(unscaledImageElement)

				Dim unscaledImageRectangle As RectangleF = unscaledImageResult.EndPageBounds

				' Add an enlarged image

				' Add section title
				subtitleTextElement = New TextElement(columnX, unscaledImageRectangle.Bottom + 10, "Enlarged small image has lower resolution", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				Dim enlargedImageTitle As AddElementResult = pdfPage.AddElement(subtitleTextElement)

				Dim enlargedImageWidth As Single = unscaledImageRectangle.Width + 35

				imagePath = "DemoAppFiles\Input\Images\picture_smaller.jpg"
				Dim enlargedImageElement As New ImageElement(columnX, enlargedImageTitle.EndPageBounds.Bottom + 10, enlargedImageWidth, imagePath)
				' Allow the image to be enlarged
				enlargedImageElement.EnlargeEnabled = True
				Dim enalargedImageResult As AddElementResult = pdfPage.AddElement(enlargedImageElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Scale an image preserving the aspect ratio

				titlesYLocation = yLocation

				' Add section title
				subtitleTextElement = New TextElement(xLocation, titlesYLocation, "Scaled down image preserving aspect ratio", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				addElementResult = pdfPage.AddElement(subtitleTextElement)

				pdfPage = addElementResult.EndPdfPage
				yLocation = addElementResult.EndPageBounds.Bottom + 10

				Dim boundingRectangle As New RectangleF(xLocation, yLocation, scaledDownImageRectangle.Width, scaledDownImageRectangle.Width)
				imagesYLocation = boundingRectangle.Y

				imagePath = "DemoAppFiles\Input\Images\landscape.jpg"
				Dim keepAspectImageElement As New ImageElement(boundingRectangle.X, imagesYLocation, boundingRectangle.Width, boundingRectangle.Width, True, imagePath)
				addElementResult = pdfPage.AddElement(keepAspectImageElement)

				borderElement = New RectangleElement(boundingRectangle)
				borderElement.ForeColor = Color.Black
				pdfPage.AddElement(borderElement)

				' Scale an image without preserving aspect ratio
				' This can produce a distorted image

				boundingRectangle = New RectangleF(addElementResult.EndPageBounds.Right + 30, addElementResult.EndPageBounds.Y, scaledDownImageRectangle.Width, scaledDownImageRectangle.Width)

				' Add section title
				subtitleTextElement = New TextElement(boundingRectangle.X, titlesYLocation, "Scaled down image without preserving aspect ratio", subtitleFont)
				subtitleTextElement.ForeColor = Color.Navy
				pdfPage.AddElement(subtitleTextElement)

				imagePath = "DemoAppFiles\Input\Images\landscape.jpg"
				Dim notKeepAspectImageElement As New ImageElement(boundingRectangle.X, imagesYLocation, boundingRectangle.Width, boundingRectangle.Width, False, imagePath)
				addElementResult = pdfPage.AddElement(notKeepAspectImageElement)

				borderElement = New RectangleElement(boundingRectangle)
				borderElement.ForeColor = Color.Black
				pdfPage.AddElement(borderElement)

				pdfPage = addElementResult.EndPdfPage
				yLocation = addElementResult.EndPageBounds.Bottom + 20

				' Add transparent images

				' Add section title
				titleTextElement = New TextElement(xLocation, yLocation, "Transparent Images", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				pdfPage = addElementResult.EndPdfPage

				imagePath = "DemoAppFiles\Input\Images\transparent.png"
				Dim trasparentImageElement As New ImageElement(xLocation, yLocation, 150, imagePath)
				addElementResult = pdfPage.AddElement(trasparentImageElement)

				imagePath = "DemoAppFiles\Input\Images\rose.png"
				trasparentImageElement = New ImageElement(addElementResult.EndPageBounds.Right + 60, yLocation + 20, 150, imagePath)
				pdfPage.AddElement(trasparentImageElement)

				pdfPage = addElementResult.EndPdfPage
				yLocation = addElementResult.EndPageBounds.Bottom + 20

				' Rotate images

				' Add section title
				titleTextElement = New TextElement(xLocation, yLocation, "Rotated Images", titleFont)
				titleTextElement.ForeColor = Color.Black
				addElementResult = pdfPage.AddElement(titleTextElement)
				yLocation = addElementResult.EndPageBounds.Bottom + 10
				pdfPage = addElementResult.EndPdfPage

				' Add a not rotated image
				imagePath = "DemoAppFiles\Input\Images\compass.png"
				Dim noRotationImageElement As New ImageElement(xLocation, yLocation, 125, imagePath)
				addElementResult = pdfPage.AddElement(noRotationImageElement)

				Dim imageXLocation As Single = addElementResult.EndPageBounds.X
				Dim imageYLocation As Single = addElementResult.EndPageBounds.Y
				Dim imageWidth As Single = addElementResult.EndPageBounds.Width
				Dim imageHeight As Single = addElementResult.EndPageBounds.Height

				' The rotated coordinates system location
				Dim rotatedImageXLocation As Single = imageXLocation + imageWidth + 20 + imageHeight
				Dim rotatedImageYLocation As Single = imageYLocation

				' Add the image rotated 90 degrees
				Dim rotate90ImageElement As New ImageElement(0, 0, 125, imagePath)
				rotate90ImageElement.Translate(rotatedImageXLocation, rotatedImageYLocation)
				rotate90ImageElement.Rotate(90)
				pdfPage.AddElement(rotate90ImageElement)

				rotatedImageXLocation += 20 + imageWidth
				rotatedImageYLocation = imageYLocation + imageHeight

				' Add the image rotated 180 degrees
				Dim rotate180ImageElement As New ImageElement(0, 0, 125, imagePath)
				rotate180ImageElement.Translate(rotatedImageXLocation, rotatedImageYLocation)
				rotate180ImageElement.Rotate(180)
				pdfPage.AddElement(rotate180ImageElement)

				rotatedImageXLocation += 20
				rotatedImageYLocation = imageYLocation + imageWidth

				' Add the image rotated 270 degrees
				Dim rotate270ImageElement As New ImageElement(0, 0, 125, imagePath)
				rotate270ImageElement.Translate(rotatedImageXLocation, rotatedImageYLocation)
				rotate270ImageElement.Rotate(270)
				pdfPage.AddElement(rotate270ImageElement)

				pdfPage = addElementResult.EndPdfPage
				yLocation = addElementResult.EndPageBounds.Bottom + 20

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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
