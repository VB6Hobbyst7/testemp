Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences
	Partial Public Class Set_Viewer_Preferences_Demo
		Inherits UserControl
		Private Sub convertToPdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles convertToPdfButton.Click
			' Create a PDF document
			Dim pdfDocument As New Document()

			' Set license key received after purchase to use the converter in licensed mode
			' Leave it not set to use the converter in demo mode
			pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c="

			' Add a page to PDF document
			Dim pdfPage As PdfPage = pdfDocument.AddPage()

			' Set the PDF Viewer Preferences

			' Set page layout to continuous one column, single page, two column left, two column right
			pdfDocument.ViewerPreferences.PageLayout = SelectedPageLayout()
			' Set page mode to default, display attachments, display thumbnails, display attachments
			pdfDocument.ViewerPreferences.PageMode = SelectedPageMode()

			' Hide the viewer menu
			pdfDocument.ViewerPreferences.HideMenuBar = hideMenuBarCheckBox.Checked
			' Hide the viewer toolbar
			pdfDocument.ViewerPreferences.HideToolbar = hideToolbarCheckBox.Checked
			' Hide scroll bars and navigation controls
			pdfDocument.ViewerPreferences.HideWindowUI = hideWindowUICheckBox.Checked

			' Display the document title in viewer title bar
			pdfDocument.ViewerPreferences.DisplayDocTitle = displayDocTitleCheckBox.Checked

			Cursor = Cursors.WaitCursor

			Dim outPdfFile As String = "DemoAppFiles\Output\PDF_Creator\Set_PDF_Viewer_Preferences.pdf"
			Try
				' Create a HTML to PDF element to add to document
				Dim htmlToPdfElement As New HtmlToPdfElement(urlTextBox.Text)

				' Optionally set a delay before conversion to allow asynchonous scripts to finish
				htmlToPdfElement.ConversionDelay = 2

				' Add the HTML to PDF element to document
				pdfPage.AddElement(htmlToPdfElement)

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

		Private Sub Set_Viewer_Preferences_Demo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pageLayoutComboBox.SelectedItem = "One Column"
			pageModeComboBox.SelectedItem = "Default"
		End Sub

		Private Function SelectedPageLayout() As ViewerPageLayout
			Select Case pageLayoutComboBox.SelectedItem.ToString()
				Case "Single Page"
					Return ViewerPageLayout.SinglePage
				Case "One Column"
					Return ViewerPageLayout.OneColumn
				Case "Two Column Left"
					Return ViewerPageLayout.TwoColumnLeft
				Case "Two Column Right"
					Return ViewerPageLayout.TwoColumnRight
				Case Else
					Return ViewerPageLayout.OneColumn
			End Select
		End Function

		Private Function SelectedPageMode() As ViewerPageMode
			Select Case pageModeComboBox.SelectedItem.ToString()
				Case "Default"
					Return ViewerPageMode.UseNone
				Case "Display Outlines"
					Return ViewerPageMode.UseOutlines
				Case "Display Thumbnails"
					Return ViewerPageMode.UseThumbs
				Case "Display Full Screen"
					Return ViewerPageMode.FullScreen
				Case "Display Optional Content Group"
					Return ViewerPageMode.UseOC
				Case "Display Attachments"
					Return ViewerPageMode.UseAttachments
				Case Else
					Return ViewerPageMode.UseNone
			End Select
		End Function

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
