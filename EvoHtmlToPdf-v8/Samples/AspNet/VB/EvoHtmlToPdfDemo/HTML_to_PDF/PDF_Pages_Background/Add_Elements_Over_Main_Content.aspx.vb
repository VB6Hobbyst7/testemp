Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
	Partial Public Class Add_Elements_Over_Main_Content
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

			' Set a handler for AfterRenderPdfPageEvent where to add the stamp in each PDF page over the main content
			AddHandler htmlToPdfConverter.AfterRenderPdfPageEvent, AddressOf htmlToPdfConverter_AfterRenderPdfPageEvent

			Try
				' The buffer to receive the generated PDF document
				Dim outPdfBuffer() As Byte = Nothing

				If convertUrlRadioButton.Checked Then
					Dim url As String = urlTextBox.Text

					' Convert the HTML page given by an URL to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertUrl(url)
				Else
					Dim htmlString As String = htmlStringTextBox.Text
					Dim baseUrl As String = baseUrlTextBox.Text

					' Convert a HTML string with a base URL to a PDF document in a memory buffer
					outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlString, baseUrl)
				End If

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Add_Elements_Over_Main_Content.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Uninstall the handler
				RemoveHandler htmlToPdfConverter.AfterRenderPdfPageEvent, AddressOf htmlToPdfConverter_AfterRenderPdfPageEvent
			End Try
		End Sub

		Private Sub htmlToPdfConverter_AfterRenderPdfPageEvent(ByVal eventParams As AfterRenderPdfPageParams)
			If Not addStampCheckBox.Checked Then
				Return
			End If

			' Get the rendered PDF page
			Dim pdfPage As PdfPage = eventParams.Page

			Dim pageNumber As Integer = eventParams.PageNumber
			Dim pageCount As Integer = eventParams.PageCount
			Dim isOddPage As Boolean = pageNumber Mod 2 <> 0

			' Get the PDF document
			Dim pdfDocument As Document = pdfPage.Document

			' Get the PDF page drawable area width and height
			Dim pdfPageWidth As Single = pdfPage.ClientRectangle.Width
			Dim pdfPageHeight As Single = pdfPage.ClientRectangle.Height

			' Create a .NET font
			Dim timesNewRomanFont As New Font("Times New Roman", 50, GraphicsUnit.Point)

			' Create a PDF font
			Dim pdfFont As PdfFont = pdfDocument.AddFont(timesNewRomanFont, True)

			' The stamp text
			Dim text As String = String.Format("Stamp on Page {0} of {1}", pageNumber, pageCount)

			' Measure the text 
			Dim textWidth As Single = pdfFont.GetTextWidth(text)

			' Calculate the PDF page diagonal
			Dim pdfPageDiagonal As Single = CSng(Math.Sqrt(pdfPageWidth * pdfPageWidth + pdfPageHeight * pdfPageHeight))

			' The text location on PDF page diagonal
			Dim xLocation As Single = (pdfPageDiagonal - textWidth) / 2

			' Create the stamp as a rotated text element
			Dim stampTextElement As New TextElement(xLocation, 0, text, pdfFont)
			stampTextElement.ForeColor = If(isOddPage, Color.Blue, Color.Green)
			stampTextElement.Rotate(CSng(Math.Atan(pdfPageHeight / pdfPageWidth) * (180 / Math.PI)))
			stampTextElement.Opacity = 75

			' Add the stamp to PDF page
			pdfPage.AddElement(stampTextElement)
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/PDF_Pages_Back/Add_Elements_in_Front.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/PDF_Pages_Back/Add_Elements_in_Front.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("PDF_Background_Foreground")
				Master.SelectNode("Add_Elements_Over_Main_Content")
			End If
		End Sub

		Protected Sub convertUrlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
		End Sub

		Protected Sub convertHtmlRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			urlPanel.Visible = convertUrlRadioButton.Checked
			htmlStringPanel.Visible = Not convertUrlRadioButton.Checked
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