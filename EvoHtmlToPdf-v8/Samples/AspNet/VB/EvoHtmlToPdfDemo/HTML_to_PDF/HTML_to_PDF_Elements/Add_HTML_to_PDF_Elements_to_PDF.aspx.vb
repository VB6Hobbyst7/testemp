Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements
	Partial Public Class Add_HTML_to_PDF_Elements_to_PDF
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Create a PDF page where to add the first HTML
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' The element location in PDF
				Dim xLocation As Single = Single.Parse(xLocationTextBox.Text)
				Dim yLocation As Single = Single.Parse(yLocationTextBox.Text)

				' The URL of the HTML page to convert to PDF
				Dim urlToConvert As String = urlTextBox.Text

				' Create the HTML to PDF element
				Dim htmlToPdfElement As New HtmlToPdfElement(xLocation, yLocation, urlToConvert)

				' Optionally set the HTML viewer width
				htmlToPdfElement.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

				' Optionally set the HTML viewer height
				If htmlViewerHeightTextBox.Text.Length > 0 Then
					htmlToPdfElement.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
				End If

				' Optionally set the HTML content clipping option to force the HTML content width to be exactly HtmlViewerWidth pixels
				htmlToPdfElement.ClipHtmlView = clipContentCheckBox.Checked

				' Optionally set the destination width in PDF
				If contentWidthTextBox.Text.Length > 0 Then
					htmlToPdfElement.Width = Single.Parse(contentWidthTextBox.Text)
				End If

				' Optionally set the destination height in PDF
				If contentHeightTextBox.Text.Length > 0 Then
					htmlToPdfElement.Height = Single.Parse(contentHeightTextBox.Text)
				End If

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to PDF document
				' The AddElementResult contains the bounds of the HTML to PDF Element in last rendered PDF page
				' such that you can start a new PDF element right under it
				Dim result As AddElementResult = firstPdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Add_HTML_to_PDF_Elements_to_PDF.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTML_to_PDF_Elements/Add_HTML_to_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTML_to_PDF_Elements/Add_HTML_to_PDF.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("HTML_to_PDF_Elements")
				Master.SelectNode("Add_HTML_to_PDF_Elements_to_PDF_Document")
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