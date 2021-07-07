Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
	Partial Public Class Define_in_HTML_Table_of_Contents_Items_Demo
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

			' Optionally set the table of contents title
			htmlToPdfConverter.TableOfContentsOptions.Title = "Table of Contents"

			' Optionally set the title style using CSS sttributes
			htmlToPdfConverter.TableOfContentsOptions.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal"

			' Optionally set the style of level 1 items in table of contents
			Dim level1TextStyle As String = "color:navy; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0"
			htmlToPdfConverter.TableOfContentsOptions.SetItemStyle(1, level1TextStyle)

			' Optionally set the page numbers style of level 1 items in table of contents
			Dim level1PageNumberStyle As String = "color:navy; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold"
			htmlToPdfConverter.TableOfContentsOptions.SetPageNumberStyle(1, level1PageNumberStyle)

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Define_in_HTML_Table_of_Contents.pdf"
			Try
				Dim outPdfBuffer() As Byte = Nothing

				If convertHtmlRadioButton.Checked Then
					Dim htmlWithBookmarkAttributes As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with table of contents to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithBookmarkAttributes, baseUrl)
				Else
					Dim url As String = urlTextBox.Text

					' Convert a HTML page with table of contents to a PDF document in a memory buffer
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

		Private Sub Define_in_HTML_Table_of_Contents_Items_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\Table_of_Contents.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"

			urlTextBox.Text = Application.StartupPath & "\DemoAppFiles\Input\HTML_Files\Table_of_Contents.html"
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
