Imports System.Web.UI
Imports System.Web.UI.WebControls


' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions
	Partial Public Class Go_To_Page_Open_Action
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

			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML page to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				Dim goToPageNumber As Integer = Integer.Parse(pageNumberTextBox.Text)
				If goToPageNumber > pdfDocument.Pages.Count Then
					Return
				End If

				' Get destination PDF page
				Dim goToPage As PdfPage = pdfDocument.Pages(goToPageNumber - 1)

				' Get the destination point in PDF page
				Dim goToX As Single = Single.Parse(xLocationTextBox.Text)
				Dim goToY As Single = Single.Parse(yLocationTextBox.Text)

				Dim goToLocation As New PointF(goToX, goToY)

				' Get the destination view mode
				Dim viewMode As DestinationViewMode = SelectedViewMode()

				' Create the destination in PDF document
				Dim goToDestination As New ExplicitDestination(goToPage, goToLocation, viewMode)

				' Set the zoom level when the destination is displayed
                If viewMode = DestinationViewMode.XYZ Then
                    goToDestination.ZoomPercentage = Integer.Parse(zoomLevelTextBox.Text)
                End If

				' Set the document Go To open action
				pdfDocument.OpenAction.Action = New PdfActionGoTo(goToDestination)

				' Save the PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = pdfDocument.Save()

				' Send the PDF as response to browser

				' Set response content type
				Response.AddHeader("Content-Type", "application/pdf")

				' Instruct the browser to open the PDF file as an attachment or inline
				Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Go_To_Page_Open_Action.pdf; size={0}", outPdfBuffer.Length.ToString()))

				' Write the PDF document buffer to HTTP response
				Response.BinaryWrite(outPdfBuffer)

				' End the HTTP response and stop the current page processing
				Response.End()
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If
			End Try
		End Sub

		Private Function SelectedViewMode() As DestinationViewMode
			Select Case viewModeComboBox.SelectedValue
				Case "X, Y and Zoom"
					Return DestinationViewMode.XYZ
				Case "Fit Window"
					Return DestinationViewMode.Fit
				Case "Fit Horizontally"
					Return DestinationViewMode.FitH
				Case "Fit Vertically"
					Return DestinationViewMode.FitV
				Case Else
					Return DestinationViewMode.XYZ
			End Select
		End Function

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				viewModeComboBox.SelectedValue = "X, Y and Zoom"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/PDF_Actions/Go_To_Page_Open_Action.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/PDF_Actions/Go_To_Page_Open_Action.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("PDF_Actions")
				Master.SelectNode("Go_To_Page_Open_Action")
			End If
		End Sub

		Protected Sub viewModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            zoomLevelPanel.Visible = SelectedViewMode() = DestinationViewMode.XYZ
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