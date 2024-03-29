﻿Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers
	Partial Public Class Header_Footer_on_Merged_HTML_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

			' Create Header
			If addHeaderCheckBox.Checked Then
				CreateHeader(pdfDocument, drawHeaderLineCheckBox.Checked)
			End If

			' Create Footer
			If addFooterCheckBox.Checked Then
				CreateFooter(pdfDocument, drawFooterLineCheckBox.Checked, addPageNumbersInFooterCheckBox.Checked)
			End If

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Header_Footer_in_Merge_Multipe_HTML.pdf"
			Try
				' Add First HTML

				' Create the first HTML to PDF element
				Dim firstHtml As New HtmlToPdfElement(0, 0, firstUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				firstHtml.ConversionDelay = 2

				' Optionally add a space between header and the content generated by this HTML to PDF element
				' The spacing for first page and the subsequent pages can be set independently
				' Leave this option not set for no spacing
				firstHtml.Y = Single.Parse(firstPageSpacingTextBox.Text)
				firstHtml.TopSpacing = Single.Parse(headerSpacingTextBox.Text)

				' Optionally add a space between footer and the content generated by this HTML to PDF element
				' Leave this option not set for no spacing
				firstHtml.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

				' Install a handler where to set header visibility in the pages where the HTML element is rendered
				AddHandler firstHtml.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Add the first HTML to PDF element to PDF document
				' The PrepareRenderPdfPageEvent event handler will be invoked for each rendered PDF page
				Dim firstAddResult As AddElementResult = firstPdfPage.AddElement(firstHtml)

				' Uninstall the handler
				RemoveHandler firstHtml.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Add Second HTML

				Dim secondPdfPage As PdfPage = Nothing
				Dim secondHtmlLocation As PointF = Point.Empty

				If startNewPageCheckBox.Checked Then
					' Create a PDF page where to add the second HTML
					secondPdfPage = pdfDocument.AddPage()
					secondHtmlLocation = PointF.Empty
				Else
					' Add the second HTML on the PDF page where the first HTML ended
					secondPdfPage = pdfDocument.Pages(firstAddResult.EndPageIndex)
					secondHtmlLocation = New PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom)
				End If

				' Create the second HTML to PDF element
				Dim secondHtml As New HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				secondHtml.ConversionDelay = 2

				' Optionally add a space between header and the content generated by this HTML to PDF element
				' Leave this option not set for no spacing
				secondHtml.TopSpacing = Single.Parse(headerSpacingTextBox.Text)

				' Optionally add a space between footer and the content generated by this HTML to PDF element
				' Leave this option not set for no spacing
				secondHtml.BottomSpacing = Single.Parse(footerSpacingTextBox.Text)

				' Install a handler where to set header visibility in the pages where the HTML element is rendered
				AddHandler secondHtml.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Add the second HTML to PDF element to PDF document
				' The PrepareRenderPdfPageEvent event handler will be invoked for each rendered PDF page
				secondPdfPage.AddElement(secondHtml)

				' Uninstall the handler
				RemoveHandler secondHtml.PrepareRenderPdfPageEvent, AddressOf htmlToPdfElement_PrepareRenderPdfPageEvent

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				pdfDocument.Close()

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		''' <summary>
		''' Creates the document header
		''' </summary>
		''' <param name="pdfDocument">The PDF document object</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub CreateHeader(ByVal pdfDocument As Document, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Header_HTML.html")

			' Add a header to document having 60 points in height
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
		''' Creates the document footer
		''' </summary>
		''' <param name="htmlToPdfConverter">The HTML to PDF Converter object</param>
		''' <param name="addPageNumbers">A flag indicating if the page numbering is present in footer</param>
		''' <param name="drawFooterLine">A flag indicating if a line should be drawn at the top of the footer</param>
		Private Sub CreateFooter(ByVal pdfDocument As Document, ByVal addPageNumbers As Boolean, ByVal drawFooterLine As Boolean)
			Dim footerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Footer_HTML.html")

			' Add a footer to document having 60 points in height
			pdfDocument.AddFooterTemplate(60)

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
				' Calculate the footer width based on PDF page size and margins
				Dim footerWidth As Single = pdfDocument.Footer.Width

				' Create a line element for the top of the footer
				Dim footerLine As New LineElement(0, 0, footerWidth, 0)

				' Set line color
				footerLine.ForeColor = Color.Gray

				' Add line element to the bottom of the footer
				pdfDocument.Footer.AddElement(footerLine)
			End If
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

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
