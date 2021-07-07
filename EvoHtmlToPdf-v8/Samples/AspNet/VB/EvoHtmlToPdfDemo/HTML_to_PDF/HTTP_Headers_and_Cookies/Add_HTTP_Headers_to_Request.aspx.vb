Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies
	Partial Public Class Add_HTTP_Headers_to_Request
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

			' Add custom HTTP headers

			If header1NameTextBox.Text.Length > 0 AndAlso header1ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestHeaders.Add(header1NameTextBox.Text, header1ValueTextBox.Text)
			End If

			If header2NameTextBox.Text.Length > 0 AndAlso header2ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestHeaders.Add(header2NameTextBox.Text, header2ValueTextBox.Text)
			End If

			If header3NameTextBox.Text.Length > 0 AndAlso header3ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestHeaders.Add(header3NameTextBox.Text, header3ValueTextBox.Text)
			End If

			If header4NameTextBox.Text.Length > 0 AndAlso header4ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestHeaders.Add(header4NameTextBox.Text, header4ValueTextBox.Text)
			End If

			If header5NameTextBox.Text.Length > 0 AndAlso header5ValueTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HttpRequestHeaders.Add(header5NameTextBox.Text, header5ValueTextBox.Text)
			End If

			' Convert the HTML page to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTTP_Headers.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTTP_Headers_Cookies/Add_HTTP_Headers.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTTP_Headers_Cookies/Add_HTTP_Headers.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("HTTP_Headers_and_Cookies")
				Master.SelectNode("Add_HTTP_Headers")
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