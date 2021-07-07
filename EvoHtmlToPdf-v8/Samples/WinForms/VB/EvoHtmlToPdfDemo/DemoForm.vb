Imports System.ComponentModel

Imports System.Text

Imports EvoHtmlToPdfDemo.HTML_to_PDF

Namespace EvoHtmlToPdfDemo
	Partial Public Class demoForm
		Inherits Form
		Private demoControl As UserControl = Nothing
		Private descriptionControl As UserControl = Nothing
		Private codeSampleControl As UserControl = Nothing

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub demoForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			ExpandAll()
		End Sub

		Private Sub ExpandAll()
			tableOfContents.Nodes("PDF_Editor").Expand()
			tableOfContents.Nodes("PDF_Creator").Expand()
			tableOfContents.Nodes("HTML_to_Image").Expand()
			tableOfContents.Nodes("HTML_to_PDF").Expand()

			tableOfContents.SelectedNode = tableOfContents.Nodes("HTML_to_PDF")
			LoadDemo(tableOfContents.SelectedNode.Name)
			tableOfContents.Focus()
		End Sub

		Private Sub CollapseAll()
			tableOfContents.Nodes("HTML_to_PDF").Collapse()
			tableOfContents.Nodes("HTML_to_Image").Collapse()
			tableOfContents.Nodes("PDF_Creator").Collapse()
			tableOfContents.Nodes("PDF_Editor").Collapse()

			tableOfContents.SelectedNode = tableOfContents.Nodes("HTML_to_PDF")
			LoadDemo(tableOfContents.SelectedNode.Name)
			tableOfContents.Focus()
		End Sub

		Private Sub tableOfContents_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tableOfContents.AfterSelect
			If tableOfContents.SelectedNode Is Nothing OrElse tableOfContents.SelectedNode.Name Is Nothing Then
				Return
			End If

			LoadDemo(tableOfContents.SelectedNode.Name)
		End Sub

		Private Sub LoadDemo(ByVal demoName As String)
			If demoControl IsNot Nothing Then
				liveDemoTabPage.Controls.Remove(demoControl)
				demoControl.Dispose()
				demoControl = Nothing

				descriptionTabPage.Controls.Remove(descriptionControl)
				descriptionControl.Dispose()
				descriptionControl = Nothing

				codeSampleTabPage.Controls.Remove(codeSampleControl)
				codeSampleControl.Dispose()
				codeSampleControl = Nothing
			End If

			Select Case demoName
				Case "HTML_to_PDF", "Getting_Started"
					demoControl = New Getting_Started_Demo()
					descriptionControl = New Getting_Started_Description()
					codeSampleControl = New Getting_Started_Sample_Code()
				Case "HTML_Content_Scaling"
					demoControl = New HTML_Content_Scaling_Demo()
					descriptionControl = New HTML_Content_Scaling_Description()
					codeSampleControl = New HTML_Content_Scaling_Sample_Code()
				Case "Merge_Multiple_HTML"
					demoControl = New Merge_Multiple_HTML_Demo()
					descriptionControl = New Merge_Multiple_HTML_Description()
					codeSampleControl = New Merge_Multiple_HTML_Sample_Code()
				Case "Merge_With_Existing_PDF"
					demoControl = New Merge_With_Existing_PDF_Demo()
					descriptionControl = New Merge_With_Existing_PDF_Description()
					codeSampleControl = New Merge_With_Existing_PDF_Sample_Code()
				Case "Partially_Convert_HTML"
					demoControl = New Partially_Convert_HTML_Demo()
					descriptionControl = New Partially_Convert_HTML_Description()
					codeSampleControl = New Partially_Convert_HTML_Sample_Code()
				Case "Repeat_HTML_Table_Header_Footer"
					demoControl = New Repeat_HTML_Table_Header_Footer_Demo()
					descriptionControl = New Repeat_HTML_Table_Header_Footer_Description()
					codeSampleControl = New Repeat_HTML_Table_Header_Footer_Sample_Code()
				Case "Page_Breaks_Control", "Insert_Page_Breaks_Using_CSS"
					demoControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Demo()
					descriptionControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Description()
					codeSampleControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Sample_Code()
				Case "Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS"
					demoControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo()
					descriptionControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Description()
					codeSampleControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Sample_Code()
				Case "Insert_Page_Breaks_Using_API"
					demoControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Demo()
					descriptionControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Description()
					codeSampleControl = New HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Sample_Code()
				Case "Avoid_Page_Breaks_Inside_HTML_Elements_Using_API"
					demoControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Demo()
					descriptionControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Description()
					codeSampleControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Sample_Code()
				Case "Avoid_Page_Breaks_Inside_Images_Using_API"
					demoControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Demo()
					descriptionControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Description()
					codeSampleControl = New HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Sample_Code()
				Case "Triggering_Modes", "Select_Triggering_Mode"
					demoControl = New HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Demo()
					descriptionControl = New HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Description()
					codeSampleControl = New HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Sample_Code()
				Case "Select_Media_Type", "Select_Screen_or_Print_Media_Type"
					demoControl = New HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Demo()
					descriptionControl = New HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Description()
					codeSampleControl = New HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Sample_Code()
				Case "PDF_Forms", "HTML_Forms_to_PDF_Forms"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Sample_Code()
				Case "Define_in_HTML_PDF_Form_Fields"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Sample_Code()
				Case "HTML_in_Header_Footer", "Headers_and_Footers"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Sample_Code()
				Case "Page_Numbers_in_HTML"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Sample_Code()
				Case "Header_Footer_Auto_Resize"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Sample_Code()
				Case "Header_Footer_in_External_PDF"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Sample_Code()
				Case "Header_Footer_Change_Per_Page"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Sample_Code()
				Case "Header_Footer_on_Merged_HTML"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Sample_Code()
				Case "Hierachical_Bookmarks", "Auto_Create_Bookmarks"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Sample_Code()
				Case "Select_Bookmarks_in_API"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Sample_Code()
				Case "Select_Bookmarks_in_HTML"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Sample_Code()
				Case "Table_of_Contents", "Auto_Create_Table_of_Contents"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Sample_Code()
				Case "Define_in_HTML_Table_of_Contents"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Description()
                    codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Sample_Code()
                Case "Merge_Table_of_Contents"
                    demoControl = New Merge_Table_of_Contents_Demo()
                    descriptionControl = New Merge_Table_of_Contents_Description()
                    codeSampleControl = New Merge_Table_of_Contents_Sample_Code()
                Case "Insert_PDF_Before_Table_of_Contents"
                    demoControl = New Insert_PDF_Pages_Before_Table_of_Contents_Demo()
                    descriptionControl = New Insert_PDF_Pages_Before_Table_of_Contents_Description()
                    codeSampleControl = New Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code()
				Case "HTML5_Features", "SVG_to_PDF"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Sample_Code()
				Case "Embed_Web_Fonts", "Web_Fonts_to_PDF"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Sample_Code()
				Case "Fonts_Embedding", "Embed_Fonts"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Sample_Code()
				Case "HTML_Elements_Location_in_PDF", "Select_in_API_Elements_to_Retrieve"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Sample_Code()
				Case "Select_in_HTML_Elements_to_Retrieve"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Sample_Code()
				Case "HTML_Elements_Visibility", "Select_in_API_Elements_to_Hide"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Sample_Code()
				Case "Select_in_HTML_Elements_to_Hide"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Sample_Code()
				Case "URI_Links_in_PDF", "Convert_URI_Links"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Samples_Code()
				Case "Custom_URI_Links"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Sample_Code()
				Case "Internal_Links_in_PDF", "Convert_Internal_Links"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Sample_Code()
				Case "Custom_Internal_Links"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Sample_Code()
				Case "File_Links_and_Attachments", "Create_File_Links_and_Attachments"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Sample_Code()
				Case "Text_Notes", "Create_Text_Notes"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Sample_Code()
				Case "PDF_Actions", "Execute_JavaScript_Open_Action"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Sample_Code()
				Case "Go_To_Page_Open_Action"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Sample_Code()
				Case "Execute_JavaScript_Button_Clicked"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Sample_Code()
				Case "Images_Quality", "Images_Scaling_and_JPEG_Compression"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Sample_Code()
				Case "Replace_Images"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Sample_Code()
				Case "HTML_to_PDF_Elements", "Add_HTML_to_PDF_Elements_to_PDF_Document"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Sample_Code()
				Case "HTML_to_Image_Elements", "Add_HTML_to_Image_Elements_to_PDF_Document"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Sample_Code()
				Case "Flash_and_Extensions", "Convert_HTML_with_Flash_to_PDF"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Sample_Code()
				Case "Watermarks_and_Stamps", "Add_Watermarks_and_Stamps"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Sample_Code()
				Case "PDF_Background_Foreground", "Add_Elements_in_Background"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Sample_Code()
				Case "Add_Elements_Over_Main_Content"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Sample_Code()
				Case "PDF_Standards", "Create_PDF_A_PDF_X_Documents"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Sample_Code()
				Case "PDF_Color_Spaces", "Create_GrayScale_CMYK_Documents"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Sample_Code()
				Case "PDF_Viewer_Preferences", "Set_Viewer_Preferences"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Sample_Code()
				Case "Set_Initial_Zoom_Level"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Sample_Code()
				Case "PDF_Security_Features", "PDF_Permissions_and_Password"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Sample_Code()
				Case "Digital_Signatures"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Sample_Code()
				Case "HTTP_GET_and_POST", "Access_Using_HTTP_GET_and_POST"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Description()
                    codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Sample_Code()
                Case "Proxy_Options"
                    demoControl = New Proxy_Options_Demo()
                    descriptionControl = New Proxy_Options_Description()
                    codeSampleControl = New Proxy_Options_Sample_Code()
				Case "HTTP_Headers_and_Cookies", "Add_HTTP_Headers"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Sample_Code()
				Case "Add_Cookies"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Sample_Code()
				Case "HTML_to_Image", "Convert_HTML_to_Image"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Sample_Code()
				Case "HTML_to_SVG", "Convert_HTML_to_SVG"
					demoControl = New EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Sample_Code()
				Case "PDF_Creator", "Create_PDF_Documents"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Sample_Code()
				Case "PDF_Creator_HTML_to_PDF_Elements"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Sample_Code()
				Case "PDF_Creator_HTML_to_Image_Elements"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Sample_Code()
				Case "Text_Elements"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Sample_Code()
				Case "Graphic_Elements"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Sample_Code()
				Case "Image_Elements"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Sample_Code()
				Case "PDF_Creator_HTML_in_Header_Footer", "PDF_Creator_Headers_and_Footers"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Sample_Code()
				Case "PDF_Creator_Page_Numbers_in_HTML"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Sample_Code()
				Case "PDF_Creator_Header_Footer_Auto_Resize"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Sample_Code()
				Case "PDF_Creator_Header_Footer_in_External_PDF"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Sample_Code()
				Case "PDF_Creator_Header_Footer_Change_Per_Page"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Sample_Code()
				Case "Bookmarks"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Sample_Code()
				Case "Create_PDF_Forms"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Sample_Code()
				Case "URI_Links"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Sample_Code()
				Case "Internal_Links"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Sample_Code()
				Case "File_Links"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Links_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Links_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Links_Sample_Code()
				Case "File_Attachments"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Sample_Code()
				Case "PDF_Creator_Text_Notes"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Sample_Code()
				Case "PDF_Creator_PDF_Actions", "PDF_Creator_Execute_JavaScript_Open_Action"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Sample_Code()
				Case "PDF_Creator_Go_To_Page_Open_Action"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Sample_Code()
				Case "PDF_Creator_Execute_JavaScript_Button_Clicked"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Sample_Code()
				Case "PDF_Creator_PDF_Viewer_Preferences", "PDF_Creator_Set_Viewer_Preferences"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Sample_Code()
				Case "PDF_Creator_Set_Initial_Zoom_Level"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Sample_Code()
				Case "PDF_Creator_PDF_Security", "PDF_Creator_PDF_Permissions_and_Password"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Sample_Code()
				Case "PDF_Creator_Digital_Signatures"
					demoControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Sample_Code()
				Case "Split_PDF"
					demoControl = New EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Sample_Code()
				Case "Merge_PDF"
					demoControl = New EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Sample_Code()
				Case "PDF_Editor", "Stamp_PDF_Documents"
					demoControl = New EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Sample_Code()
				Case "Fill_PDF_Forms"
					demoControl = New EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Demo()
					descriptionControl = New EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Description()
					codeSampleControl = New EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Sample_Code()
				Case Else
					demoControl = New Getting_Started_Demo()
					descriptionControl = New Getting_Started_Description()
					codeSampleControl = New Getting_Started_Sample_Code()
			End Select

			If demoControl IsNot Nothing Then
				demoControl.Dock = DockStyle.Fill
				liveDemoTabPage.Controls.Add(demoControl)

				descriptionControl.Dock = DockStyle.Fill
				descriptionTabPage.Controls.Add(descriptionControl)

				codeSampleControl.Dock = DockStyle.Fill
				codeSampleTabPage.Controls.Add(codeSampleControl)
			End If
		End Sub

		Private Sub collapseAllPictureBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles collapseAllPictureBox.Click
			CollapseAll()
		End Sub

		Private Sub expandAllPictureBox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles expandAllPictureBox.Click
			ExpandAll()
		End Sub

		Private Sub collapseAllLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles collapseAllLabel.Click
			CollapseAll()
		End Sub

		Private Sub expandAllLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles expandAllLabel.Click
			ExpandAll()
		End Sub

		Private Sub bannerPicture_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bannerPicture.Click
			Try
				Process.Start("http://www.evopdf.com")
			Catch
			End Try
		End Sub
	End Class
End Namespace
