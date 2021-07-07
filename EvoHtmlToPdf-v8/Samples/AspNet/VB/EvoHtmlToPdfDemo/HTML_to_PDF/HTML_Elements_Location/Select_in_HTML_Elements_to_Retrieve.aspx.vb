Imports System.Web.UI
Imports System.Web.UI.WebControls

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
	Partial Public Class Select_in_HTML_Elements_to_Retrieve
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

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

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Select_in_HTML_Elements_to_Retrieve.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/HTML_Elements_Info.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				urlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/HTML_Elements_Info.html"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTML_Elements_Location/Select_in_HTML.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTML_Elements_Location/Select_in_HTML.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("HTML_Elements_Location_in_PDF")
				Master.SelectNode("Select_in_HTML_Elements_to_Retrieve")
			End If
		End Sub

		Protected Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub demoMenu_MenuItemClick(ByVal sender As Object, ByVal e As MenuEventArgs)
			Select Case e.Item.Value
				Case "Live_Demo"
					demoMultiView.SetActiveView(liveDemoView)
				Case "Description"
					demoMultiView.SetActiveView(descriptionView)
				Case "Sample_Code"
					demoMultiView.SetActiveView(sampleCodeView)
				Case Else
			End Select
		End Sub

		Protected Sub viewHtmlLinkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect(urlTextBox.Text)
		End Sub
	End Class
End Namespace