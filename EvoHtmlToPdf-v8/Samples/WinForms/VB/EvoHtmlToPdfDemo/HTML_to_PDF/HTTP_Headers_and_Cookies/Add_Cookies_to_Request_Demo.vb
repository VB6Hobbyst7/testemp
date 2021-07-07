Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
	Partial Public Class Add_Cookies_to_Request_Demo
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

			' Add custom HTTP cookies

			If cookie1NameTextBox.Text.Length > 0 AndAlso cookie1ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestCookies.Add(cookie1NameTextBox.Text, cookie1ValueTextBox.Text)
			End If

			If cookie2NameTextBox.Text.Length > 0 AndAlso cookie2ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestCookies.Add(cookie2NameTextBox.Text, cookie2ValueTextBox.Text)
			End If

			If cookie3NameTextBox.Text.Length > 0 AndAlso cookie3ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestCookies.Add(cookie3NameTextBox.Text, cookie3ValueTextBox.Text)
			End If

			If cookie4NameTextBox.Text.Length > 0 AndAlso cookie4ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestCookies.Add(cookie4NameTextBox.Text, cookie4ValueTextBox.Text)
			End If

			If cookie5NameTextBox.Text.Length > 0 AndAlso cookie5ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestCookies.Add(cookie5NameTextBox.Text, cookie5ValueTextBox.Text)
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\HTTP_Cookies.pdf"
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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
