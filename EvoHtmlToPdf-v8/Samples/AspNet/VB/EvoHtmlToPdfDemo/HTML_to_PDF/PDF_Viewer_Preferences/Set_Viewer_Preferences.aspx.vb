Imports System.Web.UI
Imports System.Web.UI.WebControls

' Use EVO PDF Namespace
Imports EvoPdf

Namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
	Partial Public Class Set_Viewer_Preferences
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

			' Convert the HTML page to a PDF document in a memory buffer
			Dim outPdfBuffer() As Byte = htmlToPdfConverter.ConvertUrl(urlTextBox.Text)

			' Send the PDF as response to browser

			' Set response content type
			Response.AddHeader("Content-Type", "application/pdf")

			' Instruct the browser to open the PDF file as an attachment or inline
			Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Set_PDF_Viewer_Preferences.pdf; size={0}", outPdfBuffer.Length.ToString()))

			' Write the PDF document buffer to HTTP response
			Response.BinaryWrite(outPdfBuffer)

			' End the HTTP response and stop the current page processing
			Response.End()
		End Sub

		Private Function SelectedPageLayout() As ViewerPageLayout
			Select Case pageLayoutComboBox.SelectedValue
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
			Select Case pageModeComboBox.SelectedValue
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

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				pageLayoutComboBox.SelectedValue = "One Column"
				pageModeComboBox.SelectedValue = "Default"

				sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/VbNet/AspNet/HTML_to_PDF/PDF_Viewer/Set_Viewer_Preferences.html"))
				descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/PDF_Viewer/Set_Viewer_Preferences.html"))

				Master.CollapseAll()
				Master.ExpandNode("HTML_to_PDF")
				Master.ExpandNode("PDF_Viewer_Preferences")
				Master.SelectNode("Set_Viewer_Preferences")
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