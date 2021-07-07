Imports System.Web.UI
Imports System.Web.UI.WebControls

Imports System.IO

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Convert_Page_in_Same_Session
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Save variables in Session object
			Session("firstName") = firstNameTextBox.Text
			Session("lastName") = lastNameTextBox.Text
			Session("gender") = If(maleRadioButton.Checked, "Male", "Female")
			Session("haveCar") = haveCarCheckBox.Checked
			Session("carType") = carTypeDropDownList.SelectedValue
			Session("comments") = commentsTextBox.Text

			' Execute the Display_Session_Variables.aspx page and get the HTML string 
			' rendered by this page
			Dim outTextWriter As TextWriter = New StringWriter()
			Server.Execute("Display_Session_Variables.aspx", outTextWriter)

			Dim htmlStringToConvert As String = outTextWriter.ToString()

			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Use the current page URL as base URL
			Dim baseUrl As String = HttpContext.Current.Request.Url.AbsoluteUri

			' Convert the page HTML string to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertHtml(htmlStringToConvert, baseUrl)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Convert_Page_in_Same_Session.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Protected Sub previewLinkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Save variables in Session object
			Session("firstName") = firstNameTextBox.Text
			Session("lastName") = lastNameTextBox.Text
			Session("gender") = If(maleRadioButton.Checked, "Male", "Female")
			Session("haveCar") = haveCarCheckBox.Checked
			Session("carType") = carTypeDropDownList.SelectedValue
			Session("comments") = commentsTextBox.Text

			' Redirect to page to convert
			Response.Redirect("Display_Session_Variables.aspx")
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Convert_Page_in_Same_Session.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Convert_Page_in_Same_Session.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.SelectNode("Convert_Page_in_Same_Session")
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

		Protected Sub haveCarCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			selectCarTypePanel.Visible = haveCarCheckBox.Checked
		End Sub
	End Class
End Namespace