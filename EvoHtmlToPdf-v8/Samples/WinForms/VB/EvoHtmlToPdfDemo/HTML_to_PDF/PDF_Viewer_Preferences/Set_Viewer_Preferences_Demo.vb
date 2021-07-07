Imports System.ComponentModel

Imports System.Text

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
	Partial Public Class Set_Viewer_Preferences_Demo
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

			' Set the PDF Viewer Preferences

			' Set page layout to continuous one column, single page, two column left, two column right
			htmlToPdfConverter.PdfViewerPreferences.PageLayout = SelectedPageLayout()
			' Set page mode to default, display bookmarks, display thumbnails, display attachments
			htmlToPdfConverter.PdfViewerPreferences.PageMode = SelectedPageMode()

			' Hide the viewer menu
			htmlToPdfConverter.PdfViewerPreferences.HideMenuBar = hideMenuBarCheckBox.Checked
			' Hide the viewer toolbar
			htmlToPdfConverter.PdfViewerPreferences.HideToolbar = hideToolbarCheckBox.Checked
			' Hide scroll bars and navigation controls
			htmlToPdfConverter.PdfViewerPreferences.HideWindowUI = hideWindowUICheckBox.Checked

			' Display the document title in viewer title bar
			htmlToPdfConverter.PdfViewerPreferences.DisplayDocTitle = displayDocTitleCheckBox.Checked

			Cursor = Cursors.WaitCursor

			' Convert HTML to PDF using the settings above
			Dim outPdfFile As String = "DemoAppFiles\Output\HTML_to_PDF\Set_PDF_Viewer_Preferences.pdf"
			Try
				' Convert the HTML page to a PDF document in a memory buffer
				Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

				' Write the memory buffer in a PDF file
				System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer)
			Catch ex As Exception
				' The HTML to PDF conversion failed
				MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message))
				Return
			Finally
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
