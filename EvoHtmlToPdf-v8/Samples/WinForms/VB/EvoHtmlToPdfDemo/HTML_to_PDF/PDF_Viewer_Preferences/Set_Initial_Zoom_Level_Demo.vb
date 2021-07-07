Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
	Partial Public Class Set_Initial_Zoom_Level_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a HTML to PDF converter object with default settings
			Dim htmlToPdfConverter As New HtmlToPdfConverter()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

            ' Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            ' Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Set_Initial_Zoom_Level.pdf"
			Dim pdfDocument As Document = Nothing
			Try
				' Convert a HTML page to a PDF document object
				pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text)

				Dim goToPageNumber As Integer = Integer.Parse(pageNumberTextBox.Text)
				If goToPageNumber > pdfDocument.Pages.Count Then
					MessageBox.Show("The page number is too big")
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

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
				' Close the PDF document
				If pdfDocument IsNot Nothing Then
					pdfDocument.Close()
				End If

				Cursor = Cursors.Arrow
			End Try

			' Open the created PDF document in default PDF viewer
			Try
				Process.Start(outPdfFile)
			Catch ex As Exception
				MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message))
			End Try
		End Sub

		Private Sub Set_Initial_Zoom_Level_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			viewModeComboBox.SelectedItem = "X, Y and Zoom"
		End Sub

		Private Function SelectedViewMode() As DestinationViewMode
			Select Case viewModeComboBox.SelectedItem.ToString()
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

		Private Sub viewModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles viewModeComboBox.SelectedIndexChanged
            zoomLevelPanel.Visible = SelectedViewMode() = DestinationViewMode.XYZ
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
