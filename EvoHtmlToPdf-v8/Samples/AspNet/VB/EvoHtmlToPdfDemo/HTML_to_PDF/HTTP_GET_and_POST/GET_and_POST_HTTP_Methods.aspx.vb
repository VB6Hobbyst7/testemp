Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
	Partial Public Class GET_and_POST_HTTP_Methods
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

			Dim param1Name As String = If(param1NameTextBox.Text.Length > 0, param1NameTextBox.Text, "param1")
			Dim param1Value As String = If(param1ValueTextBox.Text.Length > 0, param1ValueTextBox.Text, "Value 1")

			Dim param2Name As String = If(param2NameTextBox.Text.Length > 0, param2NameTextBox.Text, "param2")
			Dim param2Value As String = If(param2ValueTextBox.Text.Length > 0, param2ValueTextBox.Text, "Value 2")

			Dim param3Name As String = If(param3NameTextBox.Text.Length > 0, param3NameTextBox.Text, "param3")
			Dim param3Value As String = If(param3ValueTextBox.Text.Length > 0, param3ValueTextBox.Text, "Value 3")

			Dim param4Name As String = If(param4NameTextBox.Text.Length > 0, param4NameTextBox.Text, "param4")
			Dim param4Value As String = If(param4ValueTextBox.Text.Length > 0, param4ValueTextBox.Text, "Value 4")

			Dim param5Name As String = If(param5NameTextBox.Text.Length > 0, param5NameTextBox.Text, "param5")
			Dim param5Value As String = If(param5ValueTextBox.Text.Length > 0, param5ValueTextBox.Text, "Value 5")

			Dim urlToConvert As String = urlTextBox.Text

			If postMethodRadioButton.Checked Then
				htmlToPdfConverter.HttpPostFields.Add(param1Name, param1Value)
				htmlToPdfConverter.HttpPostFields.Add(param2Name, param2Value)
				htmlToPdfConverter.HttpPostFields.Add(param3Name, param3Value)
				htmlToPdfConverter.HttpPostFields.Add(param4Name, param4Value)
				htmlToPdfConverter.HttpPostFields.Add(param5Name, param5Value)
			Else
				Dim getMethodUri As New Uri(urlTextBox.Text)

				Dim query As String = If(getMethodUri.Query.Length > 0, "&", "?" & String.Format("{0}={1}", param1Name, param1Value))
				query &= String.Format("&{0}={1}", param2Name, param2Value)
				query &= String.Format("&{0}={1}", param3Name, param3Value)
				query &= String.Format("&{0}={1}", param4Name, param4Value)
				query &= String.Format("&{0}={1}", param5Name, param5Value)

				urlToConvert = urlTextBox.Text & query
			End If

			' Convert the HTML page to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlToConvert)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=GET_and_POST.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTTP_GET_and_POST/GET_and_POST_HTTP_Methods.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTTP_GET_and_POST/GET_and_POST_HTTP_Methods.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("HTTP_GET_and_POST")
				Master.SelectNode("Access_Using_HTTP_GET_and_POST")
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