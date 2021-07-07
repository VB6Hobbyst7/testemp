Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Page_Numbers_in_HTML
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' Create the document footer template
				pdfDocument.AddFooterTemplate(50)

				' ----- Add HTML with Page Numbering to Footer -----

				' Create a variable HTML element with page numbering
				Dim htmlStringWithPageNumbers As String = htmlWithPageNumbersTextBox.Text
				Dim baseUrl As String = baseUrlTextBox.Text
				Dim footerHtmlWithPageNumbers As New HtmlToPdfVariableElement(htmlStringWithPageNumbers, baseUrl)

				' Set the HTML element to fit the container height
				footerHtmlWithPageNumbers.FitHeight = True

				' Add variable HTML element with page numbering to footer
				pdfDocument.Footer.AddElement(footerHtmlWithPageNumbers)

				' Optionally draw a line at the top of the footer
				If drawFooterLineCheckBox.Checked Then
					Dim footerWidth As Single = pdfDocument.Footer.Width

					' Create a line element for the top of the footer
					Dim footerLine As New LineElement(0, 0, footerWidth, 0)

					' Set line color
					footerLine.ForeColor = Color.Gray

					' Add line element to the bottom of the footer
					pdfDocument.Footer.AddElement(footerLine)
				End If

				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(0, 0, urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Optionally add a space between footer and the page body
				' Leave this option not set for no spacing
				htmlToPdfElement.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

				' Add the HTML to PDF element to document
				' This will raise the PrepareRenderPdfPageEvent event where the header and footer visibilit per page can be changed
				pdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file// Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Page_Numbers_in_HTML.pdf; size={0}", outPdfBuffer.Length.ToString()))

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

				Dim htmlWithPageNumbers As String = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Page_Numbers_in_HTML.html"))

				htmlWithPageNumbersTextBox.Text = htmlWithPageNumbers
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Headers_and_Footers/Page_Numbers_in_HTML.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Headers_and_Footers/Page_Numbers_in_HTML.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_Headers_and_Footers")
				Master.SelectNode("PDF_Creator_Page_Numbers_in_HTML")
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