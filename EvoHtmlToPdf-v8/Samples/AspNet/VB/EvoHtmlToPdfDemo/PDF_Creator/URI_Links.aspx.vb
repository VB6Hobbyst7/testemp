Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class URI_Links
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point))
				Dim subtitleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point))

				' The links text font
				Dim linkTextFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 8, FontStyle.Bold, GraphicsUnit.Point))
				linkTextFont.IsUnderline = True

				Dim xLocation As Single = 5
				Dim yLocation As Single = 5

				' Add document title
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Create URI Links in PDF Document", titleFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Make a text in PDF a link to a web page

				' Add the text element
				Dim text As String = "Click this text to open a web page!"
				Dim textWidth As Single = linkTextFont.GetTextWidth(text)
				Dim linkTextElement As New TextElement(xLocation, yLocation, text, linkTextFont)
				linkTextElement.ForeColor = Color.Navy
				addElementResult = pdfPage.AddElement(linkTextElement)

				' Create the URI link element having the size of the text element
				Dim linkRectangle As New RectangleF(xLocation, yLocation, textWidth, addElementResult.EndPageBounds.Height)
				Dim url As String = "http://www.evopdf.com"
				Dim uriLink As New LinkUrlElement(linkRectangle, url)

				' Add the URI link to PDF document
				pdfPage.AddElement(uriLink)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Make an image in PDF a link to a web page

				Dim subtitleTextElement As New TextElement(xLocation, yLocation, "Click the image below to open a web page:", subtitleFont)
				addElementResult = pdfPage.AddElement(subtitleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 5

				' Add the image element
				Dim linkImageElement As New ImageElement(xLocation, yLocation, 120, Server.MapPath("~/DemoAppFiles/Input/Images/logo.jpg"))
				addElementResult = pdfPage.AddElement(linkImageElement)

				' Create the URI link element having the size of the image element
				linkRectangle = addElementResult.EndPageBounds
				uriLink = New LinkUrlElement(linkRectangle, url)

				' Add the URI link to PDF document
				pdfPage.AddElement(uriLink)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=URI_Links.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/URI_Links.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/URI_Links.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("URI_Links")
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