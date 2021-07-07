Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_Change
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

			' Install a handler where to change the header and footer in first page
			AddHandler htmlToPdfConverter.PrepareRenderPdfPageEvent, AddressOf htmlToPdfConverter_PrepareRenderPdfPageEvent

			' Add Document Header

			' Enable header in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowHeader = True

			' Draw document header elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowHeader Then
				DrawHeader(htmlToPdfConverter, True)
			End If

			' Add Document Footer

			' Enable footer in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowFooter = True

			' Draw document footer elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowFooter Then
				DrawFooter(htmlToPdfConverter, True, True)
			End If

			' Convert the HTML page to PDF document in a memory buffer
			' The PrepareRenderPdfPageEvent event handler will be invoked for each rendered PDF page
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Change_Header_Footer_Per_Page.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		''' <summary>
		''' The handler for HtmlToPdfConverter.PrepareRenderPdfPageEvent event where you can set the visibility of header and footer
		''' in each page or you can add a custom header or footer in a page
		''' </summary>
		''' <param name="eventParams">The event parameter containin the PDF page to customize before rendering</param>
		Private Sub htmlToPdfConverter_PrepareRenderPdfPageEvent(ByVal eventParams As PrepareRenderPdfPageParams)
			If (eventParams.PageNumber = 1) AndAlso changeHeaderAndFooterCheckBox.Checked Then
				' Change the header and footer in first page with an alternative header and footer

				' The PDF page being rendered
				Dim pdfPage As PdfPage = eventParams.Page

				' Add a custom header of 80 points in height to this page
				' The default document header will be replaced in this page
				pdfPage.AddHeaderTemplate(80)
				' Draw the page header elements
				DrawAlternativePageHeader(pdfPage.Header, True)

				' Add a custom footer of 80 points in height to this page
				' The default document footer will be replaced in this page
				pdfPage.AddFooterTemplate(80)
				' Draw the page header elements
				DrawAlternativePageFooter(pdfPage.Footer, True, True)
			End If
		End Sub

		''' <summary>
		''' Draw the document header elements
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub DrawHeader(ByVal htmlToPdfConverter As HtmlToPdfConverter, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Header_HTML.html")

			' Set the header height in points
			htmlToPdfConverter.PdfHeaderOptions.HeaderHeight = 60

			' Set header background color
			htmlToPdfConverter.PdfHeaderOptions.HeaderBackColor = Color.White

			' Create a HTML element to be added in header
			Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

			' Set the HTML element to fit the container height
			headerHtml.FitHeight = True

			' Add HTML element to header
			htmlToPdfConverter.PdfHeaderOptions.AddElement(headerHtml)

			If drawHeaderLine Then
				' Calculate the header width based on PDF page size and margins
				Dim headerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

				' Calculate header height
				Dim headerHeight As Single = htmlToPdfConverter.PdfHeaderOptions.HeaderHeight

				' Create a line element for the bottom of the header
				Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

				' Set line color
				headerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the header
				htmlToPdfConverter.PdfHeaderOptions.AddElement(headerLine)
			End If
		End Sub

		''' <summary>
		''' Draw the document footer elements
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="addPageNumbers">A flag indicating if the page numbering is present in footer</param>
		''' <param name="drawFooterLine">A flag indicating if a line should be drawn at the top of the footer</param>
		Private Sub DrawFooter(ByVal htmlToPdfConverter As HtmlToPdfConverter, ByVal addPageNumbers As Boolean, ByVal drawFooterLine As Boolean)
			Dim footerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Footer_HTML.html")

			' Set the footer height in points
			htmlToPdfConverter.PdfFooterOptions.FooterHeight = 60

			' Set footer background color
			htmlToPdfConverter.PdfFooterOptions.FooterBackColor = Color.WhiteSmoke

			' Create a HTML element to be added in footer
			Dim footerHtml As New HtmlToPdfElement(footerHtmlUrl)

			' Set the HTML element to fit the container height
			footerHtml.FitHeight = True

			' Add HTML element to footer
			htmlToPdfConverter.PdfFooterOptions.AddElement(footerHtml)

			' Add page numbering
			If addPageNumbers Then
				' Create a text element with page numbering place holders &p; and & P;
				Dim footerText As New TextElement(0, 30, "Page &p; of &P;  ", New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))

				' Align the text at the right of the footer
				footerText.TextAlign = HorizontalTextAlign.Right

				' Set page numbering text color
				footerText.ForeColor = Color.Navy

				' Embed the text element font in PDF
				footerText.EmbedSysFont = True

				' Add the text element to footer
				htmlToPdfConverter.PdfFooterOptions.AddElement(footerText)
			End If

			If drawFooterLine Then
				' Calculate the footer width based on PDF page size and margins
				Dim footerWidth As Single = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width - htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				htmlToPdfConverter.PdfFooterOptions.AddElement(footerLine)
			End If
		End Sub

		''' <summary>
		''' Draw the alternative page header elements
		''' </summary>
		''' <param name="headerTemplate">The page header template</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub DrawAlternativePageHeader(ByVal headerTemplate As Template, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Header_Alt_HTML.html")

			' Create a HTML element to be added in header
			Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

			' Set the HTML element to fit the container height
			headerHtml.FitHeight = True

			' Add HTML element to header
			headerTemplate.AddElement(headerHtml)

			If drawHeaderLine Then
				Dim headerWidth As Single = headerTemplate.Width
				Dim headerHeight As Single = headerTemplate.Height

				' Create a line element for the bottom of the header
				Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

				' Set line color
				headerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the header
				headerTemplate.AddElement(headerLine)
			End If
		End Sub

		''' <summary>
		''' Draw the alternative page footer elements
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="addPageNumbers">A flag indicating if the page numbering is present in footer</param>
		''' <param name="drawFooterLine">A flag indicating if a line should be drawn at the top of the footer</param>
		Private Sub DrawAlternativePageFooter(ByVal footerTemplate As Template, ByVal addPageNumbers As Boolean, ByVal drawFooterLine As Boolean)
			Dim footerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Footer_Alt_HTML.html")

			' Create a HTML element to be added in footer
			Dim footerHtml As New HtmlToPdfElement(footerHtmlUrl)

			' Set the HTML element to fit the container height
			footerHtml.FitHeight = True

			' Add HTML element to footer
			footerTemplate.AddElement(footerHtml)

			' Add page numbering
			If addPageNumbers Then
				' Create a text element with page numbering place holders &p; and & P;
				Dim footerText As New TextElement(10, 30, "Page &p; of &P;", New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))

				' Align the text at the right of the footer
				footerText.TextAlign = HorizontalTextAlign.Left

				' Set page numbering text color
				footerText.ForeColor = Color.Navy

				' Embed the text element font in PDF
				footerText.EmbedSysFont = True

				' Add the text element to footer
				footerTemplate.AddElement(footerText)
			End If

			If drawFooterLine Then
				Dim footerWidth As Single = footerTemplate.Width

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				footerTemplate.AddElement(footerLine)
			End If
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Headers_and_Footers/Header_Footer_Change.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Headers_and_Footers/Header_Footer_Change.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Headers_and_Footers")
				Master.SelectNode("Header_Footer_Change_Per_Page")
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