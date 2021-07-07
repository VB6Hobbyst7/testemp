Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Triggering_Modes
	Partial Public Class Conversion_Triggering_Modes
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
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

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Conversion_Triggering_Modes.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Triggering_Modes.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				urlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/Triggering_Modes.html"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Triggering_Modes/Triggering_Modes.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Triggering_Modes/Triggering_Modes.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Triggering_Modes")
				Master.SelectNode("Select_Triggering_Mode")
			End If
		End Sub

		Protected Sub autoRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			conversionDelayPanel.Visible = delayedRadioButton.Checked
		End Sub

		Protected Sub delayedRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			conversionDelayPanel.Visible = delayedRadioButton.Checked
		End Sub

		Protected Sub manualRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			conversionDelayPanel.Visible = delayedRadioButton.Checked
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