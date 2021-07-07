Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions
	Partial Public Class Execute_JavaScript_Button_Clicked
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Try
				Dim htmlWithButton As String = htmlStringTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text

				' Add a HTML string with a button to PDF document
				Dim htmlToPdfElement As New HtmlToPdfElement(htmlWithButton, baseUrl)
				pdfPage.AddElement(htmlToPdfElement)

				' Get the button location in PDF
				Dim buttonMapping As HtmlElementMapping = htmlToPdfElement.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("javascript_button")
				If buttonMapping IsNot Nothing Then
					Dim buttonPdfPage As PdfPage = buttonMapping.PdfRectangles(0).PdfPage
					Dim buttonRectangle As RectangleF = buttonMapping.PdfRectangles(0).Rectangle

					' The font used for buttons text in PDF document
					Dim buttonTextFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))

					' Create a PDF form button
					Dim pdfButton As PdfFormButton = pdfDocument.Form.AddButton(buttonPdfPage, buttonRectangle, "Execute Acrobat JavaScript", buttonTextFont)

					' Set JavaScript action to be executed when the button is clicked
					Dim javaScript As String = Nothing
					If alertMessageRadioButton.Checked Then
						' JavaScript to display an alert mesage 
						javaScript = String.Format("app.alert(""{0}"")", alertMessageTextBox.Text)
					ElseIf printDialogRadioButton.Checked Then
						' JavaScript to open the print dialog
						javaScript = "print()"
					ElseIf zoomLevelRadioButton.Checked Then
						' JavaScript to set an initial zoom level 
						javaScript = String.Format("zoom={0}", Integer.Parse(zoomLevelTextBox.Text))
					End If

					' Set the JavaScript action
					pdfButton.Action = New PdfActionJavaScript(javaScript)
				End If

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Button_JavaScript_Actions.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Button_JavaScript_Actions.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/PDF_Actions/Execute_JavaScript_Button.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/PDF_Actions/Execute_JavaScript_Button.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_PDF_Actions")
				Master.SelectNode("PDF_Creator_Execute_JavaScript_Button_Clicked")
			End If
		End Sub

		Protected Sub alertMessageRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
		End Sub

		Protected Sub printDialogRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
		End Sub

		Protected Sub zoomLevelRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			zoomLevelPanel.Visible = zoomLevelRadioButton.Checked
			alertMessagePanel.Visible = alertMessageRadioButton.Checked
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