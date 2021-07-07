Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Bookmarks
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Display the bookmarks panel when the PDF document is opened in a PDF viewer
			pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseOutlines

			Try
				' The titles font used to mark various sections of the PDF document
				Dim titleFont As PdfFont = pdfDocument.AddFont(New Font("Times New Roman", 12, FontStyle.Regular, GraphicsUnit.Point))

				' Add a new PDF page to PDF document
				Dim page1 As PdfPage = pdfDocument.AddPage()
				Dim pageText As New TextElement(0, 0, "Page 1. Destination of a Top Bookmark with Fit Width View Mode.", titleFont)
				page1.AddElement(pageText)

				' Add a new PDF page to PDF document
				Dim page2 As PdfPage = pdfDocument.AddPage()
				pageText = New TextElement(0, 0, "Page 2. Destination of a Top Bookmark with Custom Zoom Level.", titleFont)
				page2.AddElement(pageText)

				' Add a new PDF page to PDF document
				Dim page3 As PdfPage = pdfDocument.AddPage()
				pageText = New TextElement(0, 0, "Page 3. Destination of a Child Bookmark with Fit Width and Height View Mode.", titleFont)
				page3.AddElement(pageText)

				' Add a new PDF page to PDF document
				Dim page4 As PdfPage = pdfDocument.AddPage()
                pageText = New TextElement(0, CLng(page4.PageSize.Height) \ 2 - 20, "Page 4. Destination of a Top Bookmark for the Middle of the Page.", titleFont)
				page4.AddElement(pageText)

				' Add a new PDF page to PDF document
				Dim page5 As PdfPage = pdfDocument.AddPage()
				pageText = New TextElement(0, 0, "Page 5. Destination of a Child Bookmark with Colored Title.", titleFont)
				page5.AddElement(pageText)

				' Add a new PDF page to PDF document
				Dim page6 As PdfPage = pdfDocument.AddPage()
				pageText = New TextElement(0, 0, "Page 6. Destination of a Child Bookmark with Italic Style Title.", titleFont)
				page6.AddElement(pageText)

				' Add a top level bookmark for first page setting destination view mode to fit viewer window horizontally
				Dim page1Destination As New ExplicitDestination(page1, New PointF(0, 0), DestinationViewMode.FitH)
				Dim page1TopBookmark As Bookmark = pdfDocument.Bookmarks.AddNewBookmark("Top Bookmark with Fit Width View Mode", page1Destination)
				page1TopBookmark.Style = PdfBookmarkStyle.Bold

				' Add a top level bookmark for second page setting the zoom level to 125%
				Dim page2Destination As New ExplicitDestination(page2, New PointF(0, 0), DestinationViewMode.XYZ)
				page2Destination.ZoomPercentage = 125
				Dim page2TopBookmark As Bookmark = pdfDocument.Bookmarks.AddNewBookmark("Top Bookmark with Custom Zoom Level", page2Destination)
				page2TopBookmark.Style = PdfBookmarkStyle.Normal

				' Add a child bookmark for third page setting destination view mode to fit viewer window horizontally and vertically
				Dim page3Destination As New ExplicitDestination(page3, New PointF(0, 0), DestinationViewMode.Fit)
				Dim page3ChildBookmark As Bookmark = page2TopBookmark.DescendantBookmarks.AddNewBookmark("Child Bookmark with Fit Width and Height View Mode", page3Destination)

				' Add a top level bookmark for fourth page with destination point in the middle of the PDF page 
                Dim page4Destination As New ExplicitDestination(page4, New PointF(0, CLng(page4.PageSize.Height) \ 2 - 20))
				Dim page4TopBookmark As Bookmark = pdfDocument.Bookmarks.AddNewBookmark("Top Bookmark for the Middle of the Page", page4Destination)
				page4TopBookmark.Style = PdfBookmarkStyle.Bold
				page4TopBookmark.Color = Color.Blue

				' Add a child bookmark with colored text
				Dim page5Destination As New ExplicitDestination(page5, New PointF(0, 0))
				Dim page5ChildBookmark As Bookmark = page4TopBookmark.DescendantBookmarks.AddNewBookmark("Child Bookmark with Colored Title", page5Destination)
				page5ChildBookmark.Color = Color.Red

				' Add a child bookmark with italic style text
				Dim page6Destination As New ExplicitDestination(page6, New PointF(0, 0))
				Dim page6ChildBookmark As Bookmark = page4TopBookmark.DescendantBookmarks.AddNewBookmark("Child Bookmark with Italic Colored Title", page6Destination)
				page6ChildBookmark.Style = PdfBookmarkStyle.Italic
				page6ChildBookmark.Color = Color.Green

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Bookmarks.pdf; size={0}", outPdfBuffer.Length.ToString()))

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
				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Bookmarks.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Bookmarks.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("Bookmarks")
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