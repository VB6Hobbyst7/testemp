Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
	Partial Public Class Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo
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

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS.pdf"
			Try
				Dim outPdfBuffer() As Byte = Nothing

				If convertHtmlRadioButton.Checked Then
					Dim htmlWithForm As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert the HTML string with page-break-inside:avoid styles to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithForm, baseUrl)
				Else
					Dim url As String = urlTextBox.Text

					' Convert the HTML page with page-break-inside:avoid styles to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertUrl(url)
				End If

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

		Private Sub Avoid_Page_Breaks_Inside_HTML_Elements_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Page_Breaks_Inside_Avoid_Using_CSS.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"

			urlTextBox.Text = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Page_Breaks_Inside_Avoid_Using_CSS.html")
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub viewHtmlLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles viewHtmlLinkLabel.LinkClicked
			Process.Start(urlTextBox.Text)
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
