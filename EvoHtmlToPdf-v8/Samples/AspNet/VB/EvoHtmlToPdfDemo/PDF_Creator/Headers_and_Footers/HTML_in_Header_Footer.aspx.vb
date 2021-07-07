﻿Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class HTML_in_Header_Footer
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Dim htmlToPdfElement As HtmlToPdfElement = Nothing
			Try
				' Add document header
				If addHeaderCheckBox.Checked Then
					AddHeader(pdfDocument, drawHeaderLineCheckBox.Checked)
				End If

				' Add document footer
				If addFooterCheckBox.Checked Then
					AddFooter(pdfDocument, addPageNumbersInFooterCheckBox.Checked, drawFooterLineCheckBox.Checked)
				End If

				' Create a HTML to PDF element to add to document
				htmlToPdfElement = New HtmlToPdfElement(0, 0, urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Install a handler where to change the header and footer in pages generated by the HTML to PDF element
				AddHandler htmlToPdfElement.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Optionally add a space between header and the page body
				' Leave this option not set for no spacing
				htmlToPdfElement.Y = Single.Parse(firstPageSpacingTextBox.Text)
				htmlToPdfElement.TopSpacing = Single.Parse(headerSpacingTextBox.Text)

				' Optionally add a space between footer and the page body
				' Leave this option not set for no spacing
				htmlToPdfElement.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

				' Add the HTML to PDF element to document
				' This will raise the PrepareRenderPdfPageEvent event where the header and footer visibilit per page can be changed
				pdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTML_in_Header_Footer.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' uninstall handler
				RemoveHandler htmlToPdfElement.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		''' <summary>
		''' The handler for HtmlToPdfElement.PrepareRenderPdfPageEvent event where you can set the visibility of header and footer
		''' in each page or you can add a custom header or footer in a page
		''' </summary>
		''' <param name="eventParams">The event parameter containin the PDF page to customize before rendering</param>
		Private Sub htmlToPdfElement_PrepareRenderPdfPageEvent(ByVal eventParams As PrepareRenderPdfPageParams)
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
		''' Add a header to document
		''' </summary>
		''' <param name="pdfDocument">The PDF document object</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub AddHeader(ByVal pdfDocument As Document, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Header_HTML.html")

			' Create the document footer template
			pdfDocument.AddHeaderTemplate(60)

			' Create a HTML element to be added in header
			Dim headerHtml As New HtmlToPdfElement(headerHtmlUrl)

			' Set the HTML element to fit the container height
			headerHtml.FitHeight = True

			' Add HTML element to header
			pdfDocument.Header.AddElement(headerHtml)

			If drawHeaderLine Then
				Dim headerWidth As Single = pdfDocument.Header.Width
				Dim headerHeight As Single = pdfDocument.Header.Height

				' Create a line element for the bottom of the header
				Dim headerLine As New LineElement(0, headerHeight - 1, headerWidth, headerHeight - 1)

				' Set line color
				headerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the header
				pdfDocument.Header.AddElement(headerLine)
			End If
		End Sub

		''' <summary>
		''' Add a footer to document
		''' </summary>
		''' <param name="pdfDocument">The PDF document object</param>
		''' <param name="addPageNumbers">A flag indicating if the page numbering is present in footer</param>
		''' <param name="drawFooterLine">A flag indicating if a line should be drawn at the top of the footer</param>
		Private Sub AddFooter(ByVal pdfDocument As Document, ByVal addPageNumbers As Boolean, ByVal drawFooterLine As Boolean)
			Dim footerHtmlUrl As String = Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Footer_HTML.html")

			' Create the document footer template
			pdfDocument.AddFooterTemplate(60)

			' Set footer background color
			Dim backColorRectangle As New RectangleElement(0, 0, pdfDocument.Footer.Width, pdfDocument.Footer.Height)
			backColorRectangle.BackColor = Color.WhiteSmoke
			pdfDocument.Footer.AddElement(backColorRectangle)

			' Create a HTML element to be added in footer
			Dim footerHtml As New HtmlToPdfElement(footerHtmlUrl)

			' Set the HTML element to fit the container height
			footerHtml.FitHeight = True

			' Add HTML element to footer
			pdfDocument.Footer.AddElement(footerHtml)

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
				pdfDocument.Footer.AddElement(footerText)
			End If

			If drawFooterLine Then
				Dim footerWidth As Single = pdfDocument.Footer.Width

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				pdfDocument.Footer.AddElement(footerLine)
			End If
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Headers_and_Footers/HTML_in_Header_Footer.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Headers_and_Footers/HTML_in_Header_Footer.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_Headers_and_Footers")
				Master.SelectNode("PDF_Creator_HTML_in_Header_Footer")
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