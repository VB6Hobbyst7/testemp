Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Header_Footer_In_External_PDF
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
				' Add a default document header
				AddHeader(pdfDocument, True)

				' Add a default document footer
				AddFooter(pdfDocument, True, True)

				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(0, 0, urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add HTML to PDF element to document
				pdfPage.AddElement(htmlToPdfElement)

				' Automatically close the external PDF documents after the final document is saved
				pdfDocument.AutoCloseAppendedDocs = True

				' Insert an external PDF document in the beginning of the final PDF document
				Dim pdfFileBefore As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf")
				Dim startExternalDocument As New Document(pdfFileBefore)
				pdfDocument.InsertDocument(0, startExternalDocument, addHeaderFooterInInsertedPdfCheckBox.Checked, showHeaderInFirstPageCheckBox.Checked, showFooterInFirstPageCheckBox.Checked)

				' Append an external PDF document at the end of the final PDF document
				Dim pdfFileAfter As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_After_Conversion.pdf")
				Dim endExternalDocument As New Document(pdfFileAfter)
				pdfDocument.AppendDocument(endExternalDocument, addHeaderFooterInAppendedPdfCheckBox.Checked, True, True)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Header_Footer_in_External_PDF.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
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
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../../"

				pdfBeforeHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf"
				pdfAfterHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Merge_After_Conversion.pdf"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Headers_and_Footers/Header_Footer_In_External_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Headers_and_Footers/Header_Footer_In_External_PDF.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.ExpandNode("PDF_Creator_Headers_and_Footers")
				Master.SelectNode("PDF_Creator_Header_Footer_in_External_PDF")
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