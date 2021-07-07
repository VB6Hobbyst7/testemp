Imports System.ComponentModel
Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Bookmarks_Demo
		Inherits UserControl
		Private Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Display the bookmarks panel when the PDF document is opened in a PDF viewer
			pdfDocument.ViewerPreferences.PageMode = ViewerPageMode.UseOutlines

			Cursor = Cursors.WaitCursor
			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Bookmarks.pdf"
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

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The PDF creation failed
				MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				pdfDocument.Close()

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
