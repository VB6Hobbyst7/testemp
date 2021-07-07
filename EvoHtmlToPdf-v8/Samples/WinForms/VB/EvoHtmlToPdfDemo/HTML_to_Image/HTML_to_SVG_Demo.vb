Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_SVG
	Partial Public Class HTML_to_SVG_Demo
		Inherits UserControl
		Private Sub convertToSvgButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToSvgButton.Click
			' Create a HTML to SVG converter object with default settings
			Dim htmlToSvgConverter As New HtmlToSvgConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToSvgConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
			htmlToSvgConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

			' Set HTML viewer height in pixels to convert the top part of a HTML page 
			' Leave it not set to convert the entire HTML
			If htmlViewerHeightTextBox.Text.Length > 0 Then
				htmlToSvgConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
			End If

			' Set the maximum time in seconds to wait for HTML page to be loaded 
			' Leave it not set for a default 60 seconds maximum wait time
			htmlToSvgConverter.NavigationTimeout = Integer.Parse(navigationTimeoutTextBox.Text)

			' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
			' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
			If conversionDelayTextBox.Text.Length > 0 Then
				htmlToSvgConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to SVG using the settings above
			Dim outSvgFile As String = "DemoAppFiles\Output\HTML_to_Image\HTML_to_SVG.svg"
			Try
				If convertUrlRadioButton.Checked Then
					Dim url As String = urlTextBox.Text

					' Convert the HTML page given by an URL to a SVG document in a memory buffer
					Dim outSvgBuffer() As Byte = htmlToSvgConverter.ConvertUrl(url)

					' Write the memory buffer in a SVG file
					System.IO.File.WriteAllBytes(outSvgFile, outSvgBuffer)
				Else
					Dim htmlString As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with a base URL to a SVG document in a memory buffer
					Dim outSvgBuffer() As Byte = htmlToSvgConverter.ConvertHtml(htmlString, baseUrl)

					' Write the memory buffer in a SVG file
					System.IO.File.WriteAllBytes(outSvgFile, outSvgBuffer)
				End If
			Catch ex As Exception
				' The HTML to SVG conversion failed
				MessageBox.Show(String.Format("HTML to SVG Error. {0}", ex.Message))
				Return
			Finally
				Cursor = Cursors.Arrow
			End Try

			' Open the created SVG file in the default SVG viewer
			Try
				Process.Start(outSvgFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created SVG file '{0}'. {1}", outSvgFile, ex.Message))
			End Try
		End Sub

		Private Sub HTML_to_SVG_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
