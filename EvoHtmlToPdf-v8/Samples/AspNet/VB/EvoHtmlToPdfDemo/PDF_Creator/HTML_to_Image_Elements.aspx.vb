Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class HTML_to_Image_Elements
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
				' The image location in PDF
				Dim xLocation As Single = Single.Parse(xLocationTextBox.Text)
				Dim yLocation As Single = Single.Parse(yLocationTextBox.Text)

				' The URL of the HTML page to convert to an image in PDF
				Dim urlToConvert As String = urlTextBox.Text

				' Create the HTML to Image element
				Dim htmlToImageElement As New HtmlToImageElement(xLocation, yLocation, urlToConvert)

				' Optionally set the HTML viewer width
				htmlToImageElement.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

				' Optionally set the HTML viewer height
				If htmlViewerHeightTextBox.Text.Length > 0 Then
					htmlToImageElement.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
				End If

				' Optionally set the HTML content clipping option to force the HTML content width to be exactly HtmlViewerWidth pixels
				htmlToImageElement.ClipHtmlView = clipContentCheckBox.Checked

				' Optionally set the destination width in PDF
				If contentWidthTextBox.Text.Length > 0 Then
					htmlToImageElement.Width = Single.Parse(contentWidthTextBox.Text)
				End If

				' Optionally set the destination height in PDF
				If contentHeightTextBox.Text.Length > 0 Then
					htmlToImageElement.Height = Single.Parse(contentHeightTextBox.Text)
				End If

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToImageElement.ConversionDelay = 2

				' Add the HTML to Image element to PDF document
				' The AddElementResult contains the bounds of the HTML to Image Element in last rendered PDF page
				' such that you can start a new PDF element right under it
				Dim result As AddElementResult = firstPdfPage.AddElement(htmlToImageElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTML_to_Image_Elements.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/HTML_to_Image_Elements.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/HTML_to_Image_Elements.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("PDF_Creator_HTML_to_Image_Elements")
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