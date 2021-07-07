Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Triggering_Modes
	Partial Public Class Conversion_Triggering_Modes_Demo
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Set the conversion triggering mode
			If autoRadioButton.Checked Then
				' Set Auto triggering mode
				htmlToPdfConverter.TriggeringMode = TriggeringMode.Auto
			ElseIf delayedRadioButton.Checked Then
				' Set delayed triggering moe
				htmlToPdfConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)
			ElseIf manualRadioButton.Checked Then
				' Set manual triggering mode
				' The conversion starts when the evoPdfConverter.startConversion() is called 
				' in JavaScript code of the converted HTML page
				htmlToPdfConverter.TriggeringMode = TriggeringMode.Manual
			End If

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Conversion_Triggering_Modes.pdf"
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

		Private Sub Conversion_Triggering_Modes_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Triggering_Modes.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"

			urlTextBox.Text = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Triggering_Modes.html")
		End Sub

		Private Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertHtmlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles convertUrlRadioButton.CheckedChanged
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Private Sub autoRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles autoRadioButton.CheckedChanged
			conversionDelayPanel.Visible = delayedRadioButton.Checked
		End Sub

		Private Sub delayedRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles delayedRadioButton.CheckedChanged
			conversionDelayPanel.Visible = delayedRadioButton.Checked
		End Sub

		Private Sub viewHtmlLinkLabel_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles viewHtmlLinkLabel.LinkClicked
			Process.Start(urlTextBox.Text)
		End Sub

		Private Sub manualRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles manualRadioButton.CheckedChanged
			conversionDelayPanel.Visible = delayedRadioButton.Checked
		End Sub
	End Class
End Namespace
