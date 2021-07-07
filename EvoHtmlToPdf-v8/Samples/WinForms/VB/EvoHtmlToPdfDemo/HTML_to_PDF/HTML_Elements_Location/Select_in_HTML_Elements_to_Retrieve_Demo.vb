Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
	Partial Public Class Select_in_HTML_Elements_to_Retrieve_Demo
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

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Select_in_HTML_Elements_to_Retrieve.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert HTML page or string with mapping attributes to a PDF document object 
				' The document can be further modified to highlight the selected elements
				If convertHtmlRadioButton.Checked Then
					Dim htmlWithMappingAttributes As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with mapping attributes to a PDF document object
					pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithMappingAttributes, baseUrl)
				Else
					Dim url As String = urlTextBox.Text

					' Convert a HTML page with mapping attributes to a PDF document object
					pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(url)
				End If

				' Display detailed information about the selected elements
				Dim htmlElementInfoBuilder As New StringBuilder()
				For Each htmlElementInfo As HtmlElementMapping In htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					' Get other information about HTML element
					Dim htmlElementTagName As String = htmlElementInfo.HtmlElementTagName
					Dim htmlElementID As String = htmlElementInfo.HtmlElementId
					Dim htmlElementMappingID As String = htmlElementInfo.MappingId
					Dim htmlElementCssClasssName As String = htmlElementInfo.HtmlElementCssClassName
					Dim htmlElementHtmlCode As String = htmlElementInfo.HtmlElementOuterHtml
					Dim htmlElementInnerHtml As String = htmlElementInfo.HtmlElementInnerHtml
					Dim htmlElementText As String = htmlElementInfo.HtmlElementText
					Dim htmlElementAttributes As System.Collections.Specialized.NameValueCollection = htmlElementInfo.HtmlElementAttributes
					Dim htmlElementRectanglesInPdf() As HtmlElementPdfRectangle = htmlElementInfo.PdfRectangles

					htmlElementInfoBuilder.AppendFormat("<br/>---------------------------------------- HTML Element Info ----------------------------------------<br/><br/>")
					htmlElementInfoBuilder.AppendFormat("<b>Tag Name:</b> {0}<br/>", htmlElementTagName)
					htmlElementInfoBuilder.AppendFormat("<b>Element ID:</b> {0}<br/>", htmlElementID)
					htmlElementInfoBuilder.AppendFormat("<b>Mapping ID:</b> {0}<br/>", htmlElementMappingID)
					htmlElementInfoBuilder.AppendFormat("<b>Text:</b> {0}<br/>", htmlElementText)

					htmlElementInfoBuilder.AppendFormat("<b>Attributes:</b><br/>")
					For i As Integer = 0 To htmlElementAttributes.Count - 1
						htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;{0} = ""{1}""<br/>", htmlElementAttributes.GetKey(i), htmlElementAttributes.Get(i))
					Next i


					htmlElementInfoBuilder.AppendFormat("<b>Location in PDF:</b><br/>")
					For i As Integer = 0 To htmlElementRectanglesInPdf.Length - 1
						Dim pdfPage As PdfPage = htmlElementRectanglesInPdf(i).PdfPage
						Dim pdfPageIndex As Integer = htmlElementRectanglesInPdf(i).PageIndex
						Dim rectangleInPdfPage As RectangleF = htmlElementRectanglesInPdf(i).Rectangle

						htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;PDF Page Index: {0}<br>", pdfPageIndex)
						htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;Rectangle: X = {0:N2} pt , Y = {1:N2} pt , W = {2:N2} pt , H = {3:N2} pt<br/>", rectangleInPdfPage.X, rectangleInPdfPage.Y, rectangleInPdfPage.Width, rectangleInPdfPage.Height)
					Next i

					htmlElementInfoBuilder.AppendFormat("<br/>")
				Next htmlElementInfo

				Dim lastPdfPage As PdfPage = htmlToPdfConverter.ConversionSummary.LastPdfPage
				Dim lastPageRectangle As RectangleF = htmlToPdfConverter.ConversionSummary.LastPageRectangle

				Dim htmlElementInfoHtml As New HtmlToPdfElement(0, lastPageRectangle.Bottom + 1, htmlElementInfoBuilder.ToString(), Nothing)
				lastPdfPage.AddElement(htmlElementInfoHtml)

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

		Private Sub Select_in_HTML_Elements_to_Retrieve_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			htmlStringTextBox.Text = System.IO.File.ReadAllText("DemoAppFiles\Input\HTML_Files\HTML_Elements_Info.html")
			baseUrlTextBox.Text = "file:///" & Application.StartupPath & "\DemoAppFiles\Input\HTML_Files/"

			urlTextBox.Text = Application.StartupPath & "\DemoAppFiles\Input\HTML_Files\HTML_Elements_Info.html"
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
