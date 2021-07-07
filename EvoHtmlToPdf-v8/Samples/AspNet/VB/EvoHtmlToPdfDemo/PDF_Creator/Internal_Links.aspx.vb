Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Internal_Links
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			' Add second page to PDF document
			Dim secondPdfPage As PdfPage = pdfDocument.AddPage()

			' Add third page to PDF document
			Dim thirdPdfPage As PdfPage = pdfDocument.AddPage()

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
				Dim titleTextElement As New TextElement(xLocation, yLocation, "Create Internal Links in PDF Document", titleFont)
				Dim addElementResult As AddElementResult = pdfPage.AddElement(titleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 15

				' Add a text in second page
				Dim secondPageTextElement As New TextElement(5, 5, "This text is the target of an internal text link", subtitleFont)
				secondPdfPage.AddElement(secondPageTextElement)

				' Add a text in third page
				Dim thirdPageTextElement As New TextElement(5, 5, "This text is the target of an internal image link", subtitleFont)
				thirdPdfPage.AddElement(thirdPageTextElement)

				' Make a text in PDF an internal link to the second page of the PDF document

				' Add the text element
				Dim text As String = "Click this text to go to the second page of this document!"
				Dim textWidth As Single = linkTextFont.GetTextWidth(text)
				Dim linkTextElement As New TextElement(xLocation, yLocation, text, linkTextFont)
				linkTextElement.ForeColor = Color.Navy
				addElementResult = pdfPage.AddElement(linkTextElement)

				' Make the text element an internal link to the second page of this document
				Dim linkRectangle As New RectangleF(xLocation, yLocation, textWidth, addElementResult.EndPageBounds.Height)
				' Create the destination in second page
				Dim secondPageDestination As New ExplicitDestination(secondPdfPage, New PointF(5, 5))
				' Create the internal link from text element to second page
				Dim internalLink As New InternalLinkElement(linkRectangle, secondPageDestination)

				' Add the internal link to PDF document
				pdfPage.AddElement(internalLink)

				yLocation = addElementResult.EndPageBounds.Bottom + 10

				' Make an image in PDF an internal link to the third page of the PDF document

				Dim subtitleTextElement As New TextElement(xLocation, yLocation, "Click the image below to go to the third page of this document:", subtitleFont)
				addElementResult = pdfPage.AddElement(subtitleTextElement)

				yLocation = addElementResult.EndPageBounds.Bottom + 5

				' Add the image element
				Dim linkImageElement As New ImageElement(xLocation, yLocation, 120, Server.MapPath("~/DemoAppFiles/Input/Images/logo.jpg"))
				addElementResult = pdfPage.AddElement(linkImageElement)

				' Make the image element an internal link to the third page of this document
				linkRectangle = addElementResult.EndPageBounds
				' Create the destination in third page
				Dim thirdPageDestination As New ExplicitDestination(thirdPdfPage, New PointF(5, 5))
				' Create the internal link from image element to third page
				internalLink = New InternalLinkElement(linkRectangle, thirdPageDestination)

				' Add the internal link to PDF document
				pdfPage.AddElement(internalLink)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Internal_Links.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Internal_Links.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Internal_Links.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("Internal_Links")
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