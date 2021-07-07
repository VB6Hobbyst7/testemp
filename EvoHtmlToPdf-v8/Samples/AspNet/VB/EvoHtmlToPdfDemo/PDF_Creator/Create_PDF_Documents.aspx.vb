Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator
	Partial Public Class Create_PDF_Documents
		Inherits System.Web.UI.Page
		Protected Sub createPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Get the PDF Standard
			' By default the Full PDF standard is used
			Dim pdfStandard As PdfStandardSubset = PdfStandardSubset.Full
			If pdfARadioButton.Checked Then
				pdfStandard = PdfStandardSubset.Pdf_A_1b
			ElseIf pdfXRadioButton.Checked Then
				pdfStandard = PdfStandardSubset.Pdf_X_1a
			End If

			' Get the Color Space
			' By default the RGB color space is used
			Dim pdfColorSpace As ColorSpace = ColorSpace.RGB
			If grayScaleRadioButton.Checked Then
				pdfColorSpace = ColorSpace.Gray
			ElseIf cmykRadioButton.Checked Then
				pdfColorSpace = ColorSpace.CMYK
			End If

			' Create the PDF document
			Dim pdfDocument As Document = Nothing

            If pdfStandard = PdfStandardSubset.Full AndAlso pdfColorSpace = ColorSpace.RGB Then
                ' Create a PDF document with default standard and color space
                pdfDocument = New Document()
            Else
                ' Create a PDF document with the selected standard and color space
                pdfDocument = New Document(pdfStandard, pdfColorSpace)
            End If

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Get the selected PDF page size
			Dim pdfPageSize As PdfPageSize = SelectedPdfPageSize()

			' Get the selected PDF page orientation
			Dim pdfPageOrientation As PdfPageOrientation = SelectedPdfPageOrientation()

			' Get the PDF page margins
			Dim pdfPageMargins As New Margins(Single.Parse(leftMarginTextBox.Text), Single.Parse(rightMarginTextBox.Text), Single.Parse(topMarginTextBox.Text), Single.Parse(bottomMarginTextBox.Text))

			' Create a PDF page in PDF document
			Dim firstPdfPage As PdfPage = pdfDocument.AddPage(pdfPageSize, pdfPageMargins, pdfPageOrientation)

			Try
				' The URL of the HTML page to convert to PDF
				Dim urlToConvert As String = "http://www.evopdf.com"

				' Create the HTML to PDF element
				Dim htmlToPdfElement As New HtmlToPdfElement(urlToConvert)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to PDF document
				firstPdfPage.AddElement(htmlToPdfElement)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Create_PDF_Documents.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				pdfDocument.Close()
			End Try
		End Sub

		Private Function SelectedPdfPageSize() As PdfPageSize
			Select Case pdfPageSizeDropDownList.SelectedValue
				Case "A0"
					Return PdfPageSize.A0
				Case "A1"
					Return PdfPageSize.A1
				Case "A10"
					Return PdfPageSize.A10
				Case "A2"
					Return PdfPageSize.A2
				Case "A3"
					Return PdfPageSize.A3
				Case "A4"
					Return PdfPageSize.A4
				Case "A5"
					Return PdfPageSize.A5
				Case "A6"
					Return PdfPageSize.A6
				Case "A7"
					Return PdfPageSize.A7
				Case "A8"
					Return PdfPageSize.A8
				Case "A9"
					Return PdfPageSize.A9
				Case "ArchA"
					Return PdfPageSize.ArchA
				Case "ArchB"
					Return PdfPageSize.ArchB
				Case "ArchC"
					Return PdfPageSize.ArchC
				Case "ArchD"
					Return PdfPageSize.ArchD
				Case "ArchE"
					Return PdfPageSize.ArchE
				Case "B0"
					Return PdfPageSize.B0
				Case "B1"
					Return PdfPageSize.B1
				Case "B2"
					Return PdfPageSize.B2
				Case "B3"
					Return PdfPageSize.B3
				Case "B4"
					Return PdfPageSize.B4
				Case "B5"
					Return PdfPageSize.B5
				Case "Flsa"
					Return PdfPageSize.Flsa
				Case "HalfLetter"
					Return PdfPageSize.HalfLetter
				Case "Ledger"
					Return PdfPageSize.Ledger
				Case "Legal"
					Return PdfPageSize.Legal
				Case "Letter"
					Return PdfPageSize.Letter
				Case "Letter11x17"
					Return PdfPageSize.Letter11x17
				Case "Note"
					Return PdfPageSize.Note
				Case Else
					Return PdfPageSize.A4
			End Select
		End Function

		Private Function SelectedPdfPageOrientation() As PdfPageOrientation
			Return If(pdfPageOrientationDropDownList.SelectedValue = "Portrait", PdfPageOrientation.Portrait, PdfPageOrientation.Landscape)
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				pdfPageSizeDropDownList.SelectedValue = "A4"
				pdfPageOrientationDropDownList.SelectedValue = "Portrait"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/PDF_Creator/Create_PDF_Documents.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/PDF_Creator/Create_PDF_Documents.html"))

				Master.CollapseAll()
				Master.ExpandNode("PDF_Creator")
				Master.SelectNode("Create_PDF_Documents")
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