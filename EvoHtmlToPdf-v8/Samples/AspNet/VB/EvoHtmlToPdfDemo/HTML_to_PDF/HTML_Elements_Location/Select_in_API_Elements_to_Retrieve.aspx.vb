Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
	Partial Public Class Select_in_API_Elements_to_Retrieve
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

			' Select the HTML elements for which to retrieve location and other information from HTML document
			htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { htmlElementsSelectorTextBox.Text }

			Dim pdfDocument As Document = Nothing
			Try
				' Convert HTML page to a PDF document object which can be further modified to highlight the selected elements
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				' Highlight the selected elements in PDF with colored rectangles
				For Each htmlElementInfo As HtmlElementMapping In htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					' Get other information about HTML element
					Dim htmlElementTagName As String = htmlElementInfo.HtmlElementTagName
					Dim htmlElementID As String = htmlElementInfo.HtmlElementId

					' Hightlight the HTML element in PDF

					' A HTML element can span over many PDF pages and therefore the mapping of the HTML element in PDF document consists 
					' in a list of rectangles, one rectangle for each PDF page where this element was rendered
					For Each htmlElementLocationInPdf As HtmlElementPdfRectangle In htmlElementInfo.PdfRectangles
						' Get the HTML element location in PDF page
						Dim htmlElementPdfPage As PdfPage = htmlElementLocationInPdf.PdfPage
						Dim htmlElementRectangleInPdfPage As RectangleF = htmlElementLocationInPdf.Rectangle

						' Highlight the HTML element element with a colored rectangle in PDF
						Dim highlightRectangle As New RectangleElement(htmlElementRectangleInPdfPage.X, htmlElementRectangleInPdfPage.Y, htmlElementRectangleInPdfPage.Width, htmlElementRectangleInPdfPage.Height)

						If htmlElementTagName.ToLower() = "h1" Then
							highlightRectangle.ForeColor = Color.Blue
						ElseIf htmlElementTagName.ToLower() = "h2" Then
							highlightRectangle.ForeColor = Color.Green
						ElseIf htmlElementTagName.ToLower() = "h3" Then
							highlightRectangle.ForeColor = Color.Red
						ElseIf htmlElementTagName.ToLower() = "h4" Then
							highlightRectangle.ForeColor = Color.Yellow
						ElseIf htmlElementTagName.ToLower() = "h5" Then
							highlightRectangle.ForeColor = Color.Indigo
						ElseIf htmlElementTagName.ToLower() = "h6" Then
							highlightRectangle.ForeColor = Color.Orange
						Else
							highlightRectangle.ForeColor = Color.Navy
						End If

						highlightRectangle.LineStyle.LineDashStyle = LineDashStyle.Solid

						htmlElementPdfPage.AddElement(highlightRectangle)
					Next htmlElementLocationInPdf
				Next htmlElementInfo

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Select_in_API_HTML_Elements_to_Retrieve.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTML_Elements_Location/Select_in_API.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTML_Elements_Location/Select_in_API.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("HTML_Elements_Location_in_PDF")
				Master.SelectNode("Select_in_API_Elements_to_Retrieve")
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