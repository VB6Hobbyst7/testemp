Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
	Partial Public Class GET_and_POST_HTTP_Methods_Demo
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

			Dim param1Name As String = If(param1NameTextBox.Text.Length > 0, param1NameTextBox.Text, "param1")
			Dim param1Value As String = If(param1ValueTextBox.Text.Length > 0, param1ValueTextBox.Text, "Value 1")

			Dim param2Name As String = If(param2NameTextBox.Text.Length > 0, param2NameTextBox.Text, "param2")
			Dim param2Value As String = If(param2ValueTextBox.Text.Length > 0, param2ValueTextBox.Text, "Value 2")

			Dim param3Name As String = If(param3NameTextBox.Text.Length > 0, param3NameTextBox.Text, "param3")
			Dim param3Value As String = If(param3ValueTextBox.Text.Length > 0, param3ValueTextBox.Text, "Value 3")

			Dim param4Name As String = If(param4NameTextBox.Text.Length > 0, param4NameTextBox.Text, "param4")
			Dim param4Value As String = If(param4ValueTextBox.Text.Length > 0, param4ValueTextBox.Text, "Value 4")

			Dim param5Name As String = If(param5NameTextBox.Text.Length > 0, param5NameTextBox.Text, "param5")
			Dim param5Value As String = If(param5ValueTextBox.Text.Length > 0, param5ValueTextBox.Text, "Value 5")

			Dim urlToConvert As String = urlTextBox.Text

			If postMethodRadioButton.Checked Then
				htmlToPdfConverter.HttpPostFields.Add(param1Name, param1Value)
				htmlToPdfConverter.HttpPostFields.Add(param2Name, param2Value)
				htmlToPdfConverter.HttpPostFields.Add(param3Name, param3Value)
				htmlToPdfConverter.HttpPostFields.Add(param4Name, param4Value)
				htmlToPdfConverter.HttpPostFields.Add(param5Name, param5Value)
			Else
				Dim getMethodUri As New Uri(urlTextBox.Text)

				Dim query As String = If(getMethodUri.Query.Length > 0, "&", "?" & String.Format("{0}={1}", param1Name, param1Value))
				query &= String.Format("&{0}={1}", param2Name, param2Value)
				query &= String.Format("&{0}={1}", param3Name, param3Value)
				query &= String.Format("&{0}={1}", param4Name, param4Value)
				query &= String.Format("&{0}={1}", param5Name, param5Value)

				urlToConvert = urlTextBox.Text & query
			End If

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\GET_and_POST.pdf"
			Try
				' Convert the HTML page to a PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlToConvert)

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
