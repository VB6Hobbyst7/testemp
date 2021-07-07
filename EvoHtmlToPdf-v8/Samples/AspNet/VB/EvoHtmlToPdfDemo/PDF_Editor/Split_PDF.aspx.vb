Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Split_PDF
		Inherits System.Web.UI.Page
		Protected Sub splitPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfDocumentToSplit As Document = Nothing
			Dim splitResultDocument1 As Document = Nothing
			Dim splitResultDocument2 As Document = Nothing
			Try
				' Load the PDF document to split
				' The document must remain opened until the PDF documents resulted after split are saved
				Dim pdfFileToSplitPath As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/PDF_Document.pdf")
				pdfDocumentToSplit = New Document(pdfFileToSplitPath)

				' Get the page count of the document to split
				Dim pageCount As Integer = pdfDocumentToSplit.Pages.Count

				' Check if the document has the minimum required number of page
				If pageCount < 2 Then
					Return
				End If

				' Create the first PDF document resulted after split
				splitResultDocument1 = New Document()
				' Set license key received after purchase
				splitResultDocument1.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="
				' Copy pages from loaded document into split result document
				splitResultDocument1.AppendDocument(pdfDocumentToSplit, 0, pageCount \ 2)
				' Save the first PDF document document resulted after split in a memory buffer
				Dim outPdfBuffer1() As Byte = splitResultDocument1.Save()

				' Create the second PDF document resulted after split  
				splitResultDocument2 = New Document()
				' Set license key received after purchase
				splitResultDocument2.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="
				' Copy pages from loaded document into split result document
				splitResultDocument2.AppendDocument(pdfDocumentToSplit, pageCount \ 2, pageCount - pageCount \ 2)
				' Save the second PDF document document resulted after split in a memory buffer
				Dim outPdfBuffer2() As Byte = splitResultDocument2.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Split_PDF_1.pdf.pdf; size={0}", outPdfBuffer1.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer1)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close all the PDF documents after the PDF documents resulted after split were already saved

				' Close the first split result document
				If splitResultDocument1 IsNot Nothing Then
					splitResultDocument1.Close()
				End If

				' Close the second split result document
				If splitResultDocument2 IsNot Nothing Then
					splitResultDocument2.Close()
				End If

				' Close the document to split
				If pdfDocumentToSplit IsNot Nothing Then
					pdfDocumentToSplit.Close()
				End If
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Editor/Split_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Editor/Split_PDF.html"))

				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../"

				pdfFileToSplitHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/PDF_Document.pdf"

				Master.CollapseAll()
				Master.ExpandNode("PDF_Editor")
				Master.SelectNode("Split_PDF")
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