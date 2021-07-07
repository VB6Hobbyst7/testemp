Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class HTML_in_Header_Footer
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

			' Install a handler where you can set header and footer visibility or create a custom header and footer in each page
			AddHandler htmlToPdfConverter.PrepareRenderPdfPageEvent, AddressOf htmlToPdfConverter_PrepareRenderPdfPageEvent

			' Add Header

			' Enable header in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowHeader = addHeaderCheckBox.Checked

			' Optionally add a space between header and the page body
			' The spacing for first page and the subsequent pages can be set independently
			' Leave this option not set for no spacing
			htmlToPdfConverter.PdfDocumentOptions.Y = Single.Parse(firstPageSpacingTextBox.Text)
			htmlToPdfConverter.PdfDocumentOptions.TopSpacing = Single.Parse(headerSpacingTextBox.Text)

			' Draw header elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowHeader Then
				DrawHeader(htmlToPdfConverter, drawHeaderLineCheckBox.Checked)
			End If

			' Add Footer

			' Enable footer in the generated PDF document
			htmlToPdfConverter.PdfDocumentOptions.ShowFooter = addFooterCheckBox.Checked

			' Optionally add a space between footer and the page body
			' Leave this option not set for no spacing
			htmlToPdfConverter.PdfDocumentOptions.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

			' Draw footer elements
			If htmlToPdfConverter.PdfDocumentOptions.ShowFooter Then
				DrawFooter(htmlToPdfConverter, addPageNumbersInFooterCheckBox.Checked, drawFooterLineCheckBox.Checked)
			End If

			' Convert the HTML page to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTML_in_Header_Footer.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
			' Set the header visibility in first, odd and even pages
			If addHeaderCheckBox.Checked Then
				If eventParams.PageNumber = 1 Then
					eventParams.Page.ShowHeader = showHeaderInFirstPageCheckBox.Checked
				ElseIf (eventParams.PageNumber Mod 2) = 0 AndAlso (Not showHeaderInEvenPagesCheckBox.Checked) Then
					eventParams.Page.ShowHeader = False
				ElseIf (eventParams.PageNumber Mod 2) = 1 AndAlso (Not showHeaderInOddPagesCheckBox.Checked) Then
					eventParams.Page.ShowHeader = False
				End If
			End If

			' Set the footer visibility in first, odd and even pages
			If addFooterCheckBox.Checked Then
				If eventParams.PageNumber = 1 Then
					eventParams.Page.ShowFooter = showFooterInFirstPageCheckBox.Checked
				ElseIf (eventParams.PageNumber Mod 2) = 0 AndAlso (Not showFooterInEvenPagesCheckBox.Checked) Then
					eventParams.Page.ShowFooter = False
				ElseIf (eventParams.PageNumber Mod 2) = 1 AndAlso (Not showFooterInOddPagesCheckBox.Checked) Then
					eventParams.Page.ShowFooter = False
				End If
			End If
		End Sub

		''' <summary>
		''' Draw the header elements
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
		''' Draw the footer elements
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

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Headers_and_Footers/HTML_in_Header_Footer.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Headers_and_Footers/HTML_in_Header_Footer.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("Headers_and_Footers")
				Master.SelectNode("HTML_in_Header_Footer")
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