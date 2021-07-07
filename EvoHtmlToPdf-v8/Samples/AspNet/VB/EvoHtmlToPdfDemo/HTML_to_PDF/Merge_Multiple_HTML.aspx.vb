Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class Merge_Multiple_HTML
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create the PDF document where to add the HTML documents
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Create a PDF page where to add the first HTML
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage()

			Try
				' Create the first HTML to PDF element
				Dim firstHtml As New HtmlToPdfElement(0, 0, firstUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				firstHtml.ConversionDelay = 2

				' Add the first HTML to PDF document
				Dim firstAddResult As AddElementResult = firstPdfPage.AddElement(firstHtml)

				Dim secondPdfPage As PdfPage = Nothing
				Dim secondHtmlLocation As PointF = Point.Empty

				If startNewPageCheckBox.Checked Then
					' Create a PDF page where to add the second HTML
					secondPdfPage = pdfDocument.AddPage()
					secondHtmlLocation = PointF.Empty
				Else
					' Add the second HTML on the PDF page where the first HTML ended
					secondPdfPage = firstAddResult.EndPdfPage
					secondHtmlLocation = New PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom)
				End If

				' Create the second HTML to PDF element
				Dim secondHtml As New HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				secondHtml.ConversionDelay = 2

				' Add the second HTML to PDF document
				secondPdfPage.AddElement(secondHtml)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Merge_Multipe_HTML.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/Merge_Multiple_HTML.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/Merge_Multiple_HTML.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.SelectNode("Merge_Multiple_HTML")
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