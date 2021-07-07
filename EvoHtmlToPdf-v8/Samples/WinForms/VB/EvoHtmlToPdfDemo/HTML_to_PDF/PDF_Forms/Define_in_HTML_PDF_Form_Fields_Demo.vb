Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms
	Partial Public Class Define_in_HTML_PDF_Form_Fields_Demo
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

			' Set the submit buttons style
			htmlToPdfConverter.PdfFormOptions.SubmitButtonStyle.BackColor = Color.Beige

			' Set the style of various types of text boxes
			htmlToPdfConverter.PdfFormOptions.TextBoxStyle.BackColor = Color.AliceBlue
			htmlToPdfConverter.PdfFormOptions.PasswordTextBoxStyle.BackColor = Color.MistyRose
			htmlToPdfConverter.PdfFormOptions.MultilineTextBoxStyle.BackColor = Color.AliceBlue

			' Set the radio buttons style
			htmlToPdfConverter.PdfFormOptions.RadioButtonsGroupStyle.BackColor = Color.AntiqueWhite

			' Set the checkboxes styles
			htmlToPdfConverter.PdfFormOptions.CheckBoxStyle.BackColor = Color.AntiqueWhite

			' set the drop down lists style
			htmlToPdfConverter.PdfFormOptions.ComboBoxStyle.BackColor = Color.LightCyan

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Define_in_HTML_PDF_Form_Fields.pdf"
			Try
				Dim outPdfBuffer() As Byte = Nothing

				If convertHtmlRadioButton.Checked Then
					' Convert a HTML string to a PDF document with form fields
					Dim htmlWithForm As String = htmlFormTextBox.Text
					outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithForm, String.Empty)
				Else
					' Convert the HTML page to a PDF document with form fields
					Dim url As String = urlTextBox.Text
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

		Private Sub Define_in_HTML_PDF_Form_Fields_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim htmlForm As String = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Select_HTML_Form_Fields.html")
			htmlFormTextBox.Text = htmlForm
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
