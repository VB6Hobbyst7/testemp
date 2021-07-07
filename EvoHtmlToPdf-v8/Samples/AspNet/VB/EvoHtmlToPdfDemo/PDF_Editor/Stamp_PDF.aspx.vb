Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Stamp_PDF
		Inherits System.Web.UI.Page
		Protected Sub stampPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfDocument As Document = Nothing
			Try
				' Load the PDF document to stamp
				Dim pdfFileToStampPath As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/PDF_Document.pdf")
				pdfDocument = New Document(pdfFileToStampPath)

				' Set license key received after purchase to use the converter in licensed mode
				' Leave it not set to use the converter in demo mode
				pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

				' Get the stamp width and height
				Dim stampWidth As Single = Single.Parse(stampWidthTextBox.Text)
				Dim stampHeight As Single = Single.Parse(stampHeightTextBox.Text)

				' Center the stamp at the top of PDF page
				Dim stampXLocation As Single = (pdfDocument.Pages(0).ClientRectangle.Width - stampWidth) / 2
				Dim stampYLocation As Single = 0

				Dim stampRectangle As New RectangleF(stampXLocation, stampYLocation, stampWidth, stampHeight)

				' Create the stamp template to be repeated in each PDF page
				Dim stampTemplate As Template = pdfDocument.AddTemplate(stampRectangle)

				' Create the HTML element to add in stamp template
				Dim stampHtmlElement As New HtmlToPdfElement(htmlStringTextBox.Text, baseUrlTextBox.Text)

				' Set the HTML viewer width for the HTML added in stamp
				stampHtmlElement.HtmlViewerWidth = 600
				' Fit the HTML content in stamp template
				stampHtmlElement.FitWidth = True
				stampHtmlElement.FitHeight = True

				' Add HTML to stamp template
				stampTemplate.AddElement(stampHtmlElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Stamp_PDF.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the document to stamp
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
                Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../"

				htmlStringTextBox.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/HTML_Files/Watermark_Stamp.html"))
				baseUrlTextBox.Text = rootUrl & "DemoAppFiles/Input/HTML_Files/"

				pdfFileToStampHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/PDF_Document.pdf"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Editor/Stamp_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Editor/Stamp_PDF.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Editor")
				Master.SelectNode("Stamp_PDF_Documents")
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