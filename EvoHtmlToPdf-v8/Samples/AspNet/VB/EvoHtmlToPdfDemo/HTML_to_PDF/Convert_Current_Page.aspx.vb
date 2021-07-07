Imports System.Web.UI
Imports System.Web.UI.WebControls

Imports System.IO
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Convert_Current_Page
		Inherits System.Web.UI.Page
		' Controls if the current HTML page will be rendered to PDF or as a normal page
		Private convertToPdf As Boolean = False

		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' The current ASP.NET page will be rendered to PDF when its Render method will be called by framework
			convertToPdf = True
		End Sub

		Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
			If convertToPdf Then
				' Get the current page HTML string by rendering into a TextWriter object
				Dim outTextWriter As TextWriter = New StringWriter()
				Dim outHtmlTextWriter As New HtmlTextWriter(outTextWriter)
				MyBase.Render(outHtmlTextWriter)

				' Obtain the current page HTML string
				Dim currentPageHtmlString As String = outTextWriter.ToString()

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

				' Convert the current page HTML string to a PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertHtml(currentPageHtmlString, baseUrl)

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Convert_Current_Page.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Else
				MyBase.Render(writer)
			End If
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Convert_Current_Page.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Convert_Current_Page.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.SelectNode("Convert_Current_Page")
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