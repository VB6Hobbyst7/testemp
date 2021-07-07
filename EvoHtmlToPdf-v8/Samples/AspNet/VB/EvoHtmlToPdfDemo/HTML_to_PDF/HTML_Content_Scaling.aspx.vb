Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF
	Partial Public Class HTML_Content_Scaling
		Inherits System.Web.UI.Page
		Protected Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			' Html Viewer Options

			' Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
			' This is a preferred width of the browser but the actual HTML content width can be larger in case the HTML page 
			' cannot be entirely displayed in the given viewer width
			' This property gives the size of the HTML content which can be further scaled to fit the PDF page based on selected options
			' The HTML content size is in pixels and the PDF page size is in points (1 point = 1/72 inches)
			' The converter is using a 96 DPI resolution to transform pixels to points with the following formula: Points = Pixels/96 * 72            
			htmlToPdfConverter.HtmlViewerWidth = Integer.Parse(htmlViewerWidthTextBox.Text)

			' Set HTML viewer height in pixels to convert the top part of a HTML page 
			' Leave it not set to convert the entire HTML
			If htmlViewerHeightTextBox.Text.Length > 0 Then
				htmlToPdfConverter.HtmlViewerHeight = Integer.Parse(htmlViewerHeightTextBox.Text)
			End If

			' Set the HTML content clipping option to force the HTML content width to be exactly HtmlViewerWidth pixels
			' If this option is false then the actual HTML content width can be larger than HtmlViewerWidth pixels in case the HTML page 
			' cannot be entirely displayed in the given viewer width
			' By default this option is false and the HTML content is not clipped
            htmlToPdfConverter.ClipHtmlView = clipContentCheckBox.Checked

            ' Set the HTML content zoom percentage similar to zoom level in a browser
            htmlToPdfConverter.HtmlViewerZoom = Integer.Parse(htmlViewerZoomTextBox.Text)

			' PDF Page Options

			' Set PDF page size which can be a predefined size like A4 or a custom size in points 
			' Leave it not set to have a default A4 PDF page
			htmlToPdfConverter.PdfDocumentOptions.PdfPageSize = SelectedPdfPageSize()

			' Set PDF page orientation to Portrait or Landscape
			' Leave it not set to have a default Portrait orientation for PDF page
			htmlToPdfConverter.PdfDocumentOptions.PdfPageOrientation = SelectedPdfPageOrientation()

			' Set PDF page margins in points or leave them not set to have a PDF page without margins
			htmlToPdfConverter.PdfDocumentOptions.LeftMargin = Single.Parse(leftMarginTextBox.Text)
			htmlToPdfConverter.PdfDocumentOptions.RightMargin = Single.Parse(rightMarginTextBox.Text)
			htmlToPdfConverter.PdfDocumentOptions.TopMargin = Single.Parse(topMarginTextBox.Text)
			htmlToPdfConverter.PdfDocumentOptions.BottomMargin = Single.Parse(bottomMarginTextBox.Text)

			' HTML Content Destination and Spacing Options

			' Set HTML content destination in PDF page
			If xLocationTextBox.Text.Length > 0 Then
				htmlToPdfConverter.PdfDocumentOptions.X = Single.Parse(xLocationTextBox.Text)
			End If
			If yLocationTextBox.Text.Length > 0 Then
				htmlToPdfConverter.PdfDocumentOptions.Y = Single.Parse(yLocationTextBox.Text)
			End If
			If contentWidthTextBox.Text.Length > 0 Then
				htmlToPdfConverter.PdfDocumentOptions.Width = Single.Parse(contentWidthTextBox.Text)
			End If
			If contentHeightTextBox.Text.Length > 0 Then
				htmlToPdfConverter.PdfDocumentOptions.Height = Single.Parse(contentHeightTextBox.Text)
			End If

			' Set HTML content top and bottom spacing or leave them not set to have no spacing for the HTML content
			htmlToPdfConverter.PdfDocumentOptions.TopSpacing = Single.Parse(topSpacingTextBox.Text)
			htmlToPdfConverter.PdfDocumentOptions.BottomSpacing = Single.Parse(bottomSpacingTextBox.Text)

			' Scaling Options

			' Use this option to fit the HTML content width in PDF page width
			' By default this property is true and the HTML content can be resized to fit the PDF page width
			htmlToPdfConverter.PdfDocumentOptions.FitWidth = fitWidthCheckBox.Checked

			' Use this option to enable the HTML content stretching when its width is smaller than PDF page width
			' This property has effect only when FitWidth option is true
			' By default this property is false and the HTML content is not stretched
			htmlToPdfConverter.PdfDocumentOptions.StretchToFit = stretchCheckBox.Checked

			' Use this option to automatically dimension the PDF page to display the HTML content unscaled
			' This property has effect only when the FitWidth property is false
			' By default this property is true and the PDF page is automatically dimensioned when FitWidth is false
			htmlToPdfConverter.PdfDocumentOptions.AutoSizePdfPage = autoSizeCheckBox.Checked

			' Use this option to fit the HTML content height in PDF page height
			' If both FitWidth and FitHeight are true then the HTML content will resized if necessary to fit both width and height 
			' preserving the aspect ratio at the same time
			' By default this property is false and the HTML content is not resized to fit the PDF page height
			htmlToPdfConverter.PdfDocumentOptions.FitHeight = fitHeightCheckBox.Checked

			' Use this option to render the whole HTML content into a single PDF page
			' The PDF page size is limited to 14400 points
			' By default this property is false
			htmlToPdfConverter.PdfDocumentOptions.SinglePage = singlePageCheckBox.Checked

			Dim url As String = urlTextBox.Text

			' Convert the HTML page to a PDF document using the scaling options
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(url)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=HTML_Content_Scaling.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
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

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/HTML_Content_Scaling.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/HTML_Content_Scaling.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.SelectNode("HTML_Content_Scaling")
			End If
		End Sub

		Protected Sub fitWidthCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			autoSizeCheckBox.Visible = Not fitWidthCheckBox.Checked
			stretchCheckBox.Visible = fitWidthCheckBox.Checked
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