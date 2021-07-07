Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Editor
	Partial Public Class Merge_PDF
		Inherits System.Web.UI.Page
		Protected Sub mergePdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create the merge result PDF document
			Dim mergeResultPdfDocument As New Document()

			' Automatically close the merged documents when the document resulted after merge is closed
			mergeResultPdfDocument.AutoCloseAppendedDocs = True

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			mergeResultPdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			Try
				' The documents to merge must remain opened until the PDF document resulted after merge is saved
				' The merged documents can be automatically closed when the document resulted after merge is closed
				' if the AutoCloseAppendedDocs property of the PDF document resulted after merge is set on true like
				' in this demo applcation

				' Load the first PDF document to merge
				Dim firstPdfFilePath As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf")
				Dim firstPdfDocumentToMerge As New Document(firstPdfFilePath)
				' Merge the first PDF document
				mergeResultPdfDocument.AppendDocument(firstPdfDocumentToMerge)

				' Load the second PDF document to merge
				Dim secondPdfFilePath As String = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_After_Conversion.pdf")
				Dim secondPdfDocumentToMerge As New Document(secondPdfFilePath)
				' Merge the second PDF document
				mergeResultPdfDocument.AppendDocument(secondPdfDocumentToMerge)

				' Save the merge result PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = mergeResultPdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Merge_PDF.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document resulted after merge
				' When the AutoCloseAppendedDocs property is true the merged PDF documents will also be closed
				mergeResultPdfDocument.Close()
			End Try
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Editor/Merge_PDF.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Editor/Merge_PDF.html"))

				Dim currentPageUrl As String = HttpContext.Current.Request.Url.AbsoluteUri
				Dim rootUrl As String = currentPageUrl.Substring(0, currentPageUrl.LastIndexOf("/"c)) & "/../"

				firstPdfFileHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf"
				secondPdfFileHyperLink.NavigateUrl = rootUrl & "DemoAppFiles/Input/PDF_Files/Merge_After_Conversion.pdf"

				Master.CollapseAll()
				Master.ExpandNode("PDF_Editor")
				Master.SelectNode("Merge_PDF")
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