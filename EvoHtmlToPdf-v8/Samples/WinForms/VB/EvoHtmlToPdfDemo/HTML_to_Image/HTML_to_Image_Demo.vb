Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_Image
	Partial Public Class HTML_to_Image_Demo
		Inherits UserControl
		Private Sub convertToImageButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToImageButton.Click
			' Create a HTML to Image converter object with default settings
			Dim htmlToImageConverter As New HtmlToImageConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToImageConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
			htmlToImageConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

			' Set HTML viewer height in pixels to convert the top part of a HTML page 
			' Leave it not set to convert the entire HTML
			If htmlViewerHeightTextBox.Text.Length > 0 Then
				htmlToImageConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
			End If

			' Set if the created image has a transparent background
			htmlToImageConverter.TransparentBackground = If(SelectedImageFormat() Is System.Drawing.Imaging.ImageFormat.Png, transparentBackgroundCheckBox.Checked, False)

			' Set the maximum time in seconds to wait for HTML page to be loaded 
			' Leave it not set for a default 60 seconds maximum wait time
			htmlToImageConverter.NavigationTimeout = Integer.Parse(navigationTimeoutTextBox.Text)

			' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
			' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
			If conversionDelayTextBox.Text.Length > 0 Then
				htmlToImageConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to Image using the settings above
			Dim outImageFile As String = "DemoAppFiles\Output\HTML_to_Image\HTML_to_Image." & imageFormatComboBox.SelectedItem.ToString().ToLower()
			Dim imageTiles() As Image = Nothing
			Try
				If convertUrlRadioButton.Checked Then
					Dim url As String = urlTextBox.Text

					' Convert the HTML page given by an URL to a set of Image objects
					imageTiles = htmlToImageConverter.ConvertUrlToImageTiles(url)
				Else
					Dim htmlString As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with a base URL to a set of Image objects
					imageTiles = htmlToImageConverter.ConvertHtmlToImageTiles(htmlString, baseUrl)
				End If

				' Save the first image tile to a memory buffer

				Dim outImage As Image = imageTiles(0)

				' Create a memory stream where to save the image
				Dim imageOutputStream As New System.IO.MemoryStream()

				' Save the image to memory stream
				outImage.Save(imageOutputStream, SelectedImageFormat())

				' Write the memory stream to a memory buffer
				imageOutputStream.Position = 0
				Dim outImageBuffer() As Byte = imageOutputStream.ToArray()

				' Close the output memory stream
				imageOutputStream.Close()

				' Write the memory buffer in an image file
				System.IO.File.WriteAllBytes(outImageFile, outImageBuffer)
			Catch ex As Exception
				' The HTML to Image conversion failed
				MessageBox.Show(String.Format("HTML to Image Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow
			End Try

			' Open the created image in the default viewer for image format
			Try
				Process.Start(outImageFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created image file '{0}'. {1}", outImageFile, ex.Message))
			End Try
		End Sub

		Private Function SelectedImageFormat() As System.Drawing.Imaging.ImageFormat
			Select Case imageFormatComboBox.SelectedItem.ToString()
				Case "Png"
					Return System.Drawing.Imaging.ImageFormat.Png
				Case "Jpg"
					Return System.Drawing.Imaging.ImageFormat.Jpeg
				Case "Bmp"
					Return System.Drawing.Imaging.ImageFormat.Bmp
				Case Else
					Return System.Drawing.Imaging.ImageFormat.Png
			End Select
		End Function

		Private Sub HTML_to_Image_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked

			imageFormatComboBox.SelectedItem = "Png"
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub imageFormatComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imageFormatComboBox.SelectedIndexChanged
			transparentBackgroundCheckBox.Visible = SelectedImageFormat() Is System.Drawing.Imaging.ImageFormat.Png
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
