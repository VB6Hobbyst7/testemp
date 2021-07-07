Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_Image
	Partial Public Class HTML_to_SVG
		Inherits System.Web.UI.Page
		Protected Sub convertToSvgButton_Click(ByVal sender As Object, ByVal e As EventArgs)
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

			' The buffer to receive the generated SVG document
			Dim outSvgBuffer() As Byte = Nothing

			If convertUrlRadioButton.Checked Then
				Dim url As String = urlTextBox.Text

				' Convert the HTML page given by an URL to a SVG document in a memory buffer
				outSvgBuffer = htmlToSvgConverter.ConvertUrl(url)
			Else
				Dim htmlString As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Convert a HTML string with a base URL to a SVG document in a memory buffer
				outSvgBuffer = htmlToSvgConverter.ConvertHtml(htmlString, baseUrl)
			End If

			' Send the SVG as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "image/svg+xml")

			' Instruct the browser to open the SVG file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTML_to_SVG.svg; size={0}", outSvgBuffer.Length.ToString()))

			' Write the SVG document buffer to HTTP response
			Response.BinaryWrite(outSvgBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				urlPanel.Visible = convertUrlRadioButton.Checked
				htmlStringPanel.Visible = Not convertUrlRadioButton.Checked

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_Image/HTML_to_SVG.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_Image/HTML_to_SVG.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_Image")
				Master.SelectNode("Convert_HTML_to_SVG")
			End If
		End Sub

		Protected Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
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
	End Class
End Namespace