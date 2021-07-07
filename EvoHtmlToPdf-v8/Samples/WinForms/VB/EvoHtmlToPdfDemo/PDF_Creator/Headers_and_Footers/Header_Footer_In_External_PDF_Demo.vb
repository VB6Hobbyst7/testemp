Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
	Partial Public Class Header_Footer_In_External_PDF_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a PDF page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Header_Footer_in_External_PDF.pdf"
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
				Dim startExternalDocument As New Document(pdfBeforeTextBox.Text)
				pdfDocument.InsertDocument(0, startExternalDocument, addHeaderFooterInInsertedPdfCheckBox.Checked, showHeaderInFirstPageCheckBox.Checked, showFooterInFirstPageCheckBox.Checked)

				' Append an external PDF document at the end of the final PDF document
				Dim endExternalDocument As New Document(pdfAfterTextBox.Text)
				pdfDocument.AppendDocument(endExternalDocument, addHeaderFooterInAppendedPdfCheckBox.Checked, True, True)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The PDF creation failed
				MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
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
		''' Add a header to document
		''' </summary>
		''' <param name="pdfDocument">The PDF document object</param>
		''' <param name="drawHeaderLine">A flag indicating if a line should be drawn at the bottom of the header</param>
		Private Sub AddHeader(ByVal pdfDocument As Document, ByVal drawHeaderLine As Boolean)
			Dim headerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Header_HTML.html")

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
			Dim footerHtmlUrl As String = System.IO.Path.Combine(Application.StartupPath, "DemoAppFiles\Input\HTML_Files\Footer_HTML.html")

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

		Private Sub Header_Footer_In_External_PDF_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pdfBeforeTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf"
			pdfAfterTextBox.Text = "DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf"
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
