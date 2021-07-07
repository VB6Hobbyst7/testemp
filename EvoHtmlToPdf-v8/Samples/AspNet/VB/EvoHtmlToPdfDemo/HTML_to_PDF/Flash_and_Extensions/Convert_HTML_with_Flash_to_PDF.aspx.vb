Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions
	Partial Public Class Convert_HTML_with_Flash_to_PDF
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Enable extensions including the Flash support
			' The converter does not have a built-in Flash player and it uses the installed Flash plugin
			' for Google Chrome or Mozilla Firefox
			htmlToPdfConverter.ExtensionsEnabled = extensionsEnabledCheckBox.Checked

			' Set an adddional delay in seconds to wait for Flash to run
			' Set this property to 0 if you want to start conversion immediately
			htmlToPdfConverter.ConversionDelay = Integer.Parse(conversionDelayTextBox.Text)

			' Convert the HTML page with Flash to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Flash_to_PDF.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Flash_Extensions/HTML_Flash_to_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Flash_Extensions/HTML_Flash_to_PDF.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Flash_and_Extensions")
				Master.SelectNode("Convert_HTML_with_Flash_to_PDF")
			End If
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