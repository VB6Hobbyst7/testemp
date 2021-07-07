using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

using EvoHtmlToPdfDemo.HTML_to_PDF;

namespace EvoHtmlToPdfDemo
{
    public partial class demoForm : Form
    {
        private UserControl demoControl = null;
        private UserControl descriptionControl = null;
        private UserControl codeSampleControl = null;

        public demoForm()
        {
            InitializeComponent();
        }

        private void demoForm_Load(object sender, EventArgs e)
        {
            ExpandAll();
        }

        private void ExpandAll()
        {
            tableOfContents.Nodes["PDF_Editor"].Expand();
            tableOfContents.Nodes["PDF_Creator"].Expand();
            tableOfContents.Nodes["HTML_to_Image"].Expand();            
            tableOfContents.Nodes["HTML_to_PDF"].Expand();

            tableOfContents.SelectedNode = tableOfContents.Nodes["HTML_to_PDF"];
            LoadDemo(tableOfContents.SelectedNode.Name);
            tableOfContents.Focus();
        }

        private void CollapseAll()
        {
            tableOfContents.Nodes["HTML_to_PDF"].Collapse();
            tableOfContents.Nodes["HTML_to_Image"].Collapse();
            tableOfContents.Nodes["PDF_Creator"].Collapse();
            tableOfContents.Nodes["PDF_Editor"].Collapse();

            tableOfContents.SelectedNode = tableOfContents.Nodes["HTML_to_PDF"];
            LoadDemo(tableOfContents.SelectedNode.Name);
            tableOfContents.Focus();
        }

        private void tableOfContents_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tableOfContents.SelectedNode == null || tableOfContents.SelectedNode.Name == null)
                return;

            LoadDemo(tableOfContents.SelectedNode.Name);
        }

        private void LoadDemo(string demoName)
        {
            if (demoControl != null)
            {
                liveDemoTabPage.Controls.Remove(demoControl);
                demoControl.Dispose();
                demoControl = null;

                descriptionTabPage.Controls.Remove(descriptionControl);
                descriptionControl.Dispose();
                descriptionControl = null;

                codeSampleTabPage.Controls.Remove(codeSampleControl);
                codeSampleControl.Dispose();
                codeSampleControl = null;
            }

            switch (demoName)
            {
                case "HTML_to_PDF":
                case "Getting_Started":
                    demoControl = new Getting_Started_Demo();
                    descriptionControl = new Getting_Started_Description();
                    codeSampleControl = new Getting_Started_Sample_Code();
                    break;
                case "HTML_Content_Scaling":
                    demoControl = new HTML_Content_Scaling_Demo();
                    descriptionControl = new HTML_Content_Scaling_Description();
                    codeSampleControl = new HTML_Content_Scaling_Sample_Code();
                    break;
                case "Merge_Multiple_HTML":
                    demoControl = new Merge_Multiple_HTML_Demo();
                    descriptionControl = new Merge_Multiple_HTML_Description();
                    codeSampleControl = new Merge_Multiple_HTML_Sample_Code();
                    break;
                case "Merge_With_Existing_PDF":
                    demoControl = new Merge_With_Existing_PDF_Demo();
                    descriptionControl = new Merge_With_Existing_PDF_Description();
                    codeSampleControl = new Merge_With_Existing_PDF_Sample_Code();
                    break;
                case "Partially_Convert_HTML":
                    demoControl = new Partially_Convert_HTML_Demo();
                    descriptionControl = new Partially_Convert_HTML_Description();
                    codeSampleControl = new Partially_Convert_HTML_Sample_Code();
                    break;
                case "Repeat_HTML_Table_Header_Footer":
                    demoControl = new Repeat_HTML_Table_Header_Footer_Demo();
                    descriptionControl = new Repeat_HTML_Table_Header_Footer_Description();
                    codeSampleControl = new Repeat_HTML_Table_Header_Footer_Sample_Code();
                    break;
                case "Page_Breaks_Control":
                case "Insert_Page_Breaks_Using_CSS":
                    demoControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Demo();
                    descriptionControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Description();
                    codeSampleControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_CSS_Sample_Code();
                    break;
                case "Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS":
                    demoControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Demo();
                    descriptionControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Description();
                    codeSampleControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS_Sample_Code();
                    break;
                case "Insert_Page_Breaks_Using_API":
                    demoControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Demo();
                    descriptionControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Description();
                    codeSampleControl = new HTML_to_PDF.Page_Breaks.Insert_Page_Breaks_Before_After_Using_API_Sample_Code();
                    break;
                case "Avoid_Page_Breaks_Inside_HTML_Elements_Using_API":
                    demoControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Demo();
                    descriptionControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Description();
                    codeSampleControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Sample_Code();
                    break;
                case "Avoid_Page_Breaks_Inside_Images_Using_API":
                    demoControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Demo();
                    descriptionControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Description();
                    codeSampleControl = new HTML_to_PDF.Page_Breaks.Avoid_Page_Breaks_Inside_Images_Using_API_Sample_Code();
                    break;
                case "Triggering_Modes":
                case "Select_Triggering_Mode":
                    demoControl = new HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Demo();
                    descriptionControl = new HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Description();
                    codeSampleControl = new HTML_to_PDF.Triggering_Modes.Conversion_Triggering_Modes_Sample_Code();
                    break;
                case "Select_Media_Type":
                case "Select_Screen_or_Print_Media_Type":
                    demoControl = new HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Demo();
                    descriptionControl = new HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Description();
                    codeSampleControl = new HTML_to_PDF.Media_Types.Select_Screen_or_Print_Media_Type_Sample_Code();
                    break;
                case "PDF_Forms":
                case "HTML_Forms_to_PDF_Forms":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Auto_Create_PDF_Forms_Sample_Code();
                    break;
                case "Define_in_HTML_PDF_Form_Fields":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Forms.Define_in_HTML_PDF_Form_Fields_Sample_Code();
                    break;
                case "HTML_in_Header_Footer":
                case "Headers_and_Footers":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.HTML_in_Header_Footer_Sample_Code();
                    break;
                case "Page_Numbers_in_HTML":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Page_Numbers_in_HTML_Sample_Code();
                    break;
                case "Header_Footer_Auto_Resize":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Auto_Resize_Sample_Code();
                    break;
                case "Header_Footer_in_External_PDF":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_In_External_PDF_Sample_Code();
                    break;
                case "Header_Footer_Change_Per_Page":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_Change_Sample_Code();
                    break;
                case "Header_Footer_on_Merged_HTML":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers.Header_Footer_on_Merged_HTML_Sample_Code();
                    break;
                case "Hierachical_Bookmarks":
                case "Auto_Create_Bookmarks":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Auto_Create_Bookmarks_Sample_Code();
                    break;
                case "Select_Bookmarks_in_API":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_API_HTML_Elements_to_Bookmark_Sample_Code();
                    break;
                case "Select_Bookmarks_in_HTML":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Bookmarks.Select_in_HTML_Elements_to_Bookmark_Sample_Code();
                    break;
                case "Table_of_Contents":
                case "Auto_Create_Table_of_Contents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Auto_Create_Table_of_Contents_Sample_Code();
                    break;
                case "Define_in_HTML_Table_of_Contents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Define_in_HTML_Table_of_Contents_Items_Sample_Code();
                    break;
                case "Merge_Table_of_Contents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Merge_Table_of_Contents_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Merge_Table_of_Contents_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Merge_Table_of_Contents_Sample_Code();
                    break;
                case "Insert_PDF_Before_Table_of_Contents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Insert_PDF_Pages_Before_Table_of_Contents_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Insert_PDF_Pages_Before_Table_of_Contents_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents.Insert_PDF_Pages_Before_Table_of_Contents_Sample_Code();
                    break;
                case "HTML5_Features":
                case "SVG_to_PDF":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.SVG_to_PDF_Sample_Code();
                    break;
                case "Embed_Web_Fonts":
                case "Web_Fonts_to_PDF":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML5_Features.Web_Fonts_to_PDF_Sample_Code();
                    break;
                case "Fonts_Embedding":
                case "Embed_Fonts":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Fonts_Embedding.Embed_Fonts_in_PDF_Sample_Code();
                    break;
                case "HTML_Elements_Location_in_PDF":
                case "Select_in_API_Elements_to_Retrieve":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_API_Elements_to_Retrieve_Sample_Code();
                    break;
                case "Select_in_HTML_Elements_to_Retrieve":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location.Select_in_HTML_Elements_to_Retrieve_Sample_Code();
                    break;
                case "HTML_Elements_Visibility":
                case "Select_in_API_Elements_to_Hide":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_API_Elements_to_Hide_Sample_Code();
                    break;
                case "Select_in_HTML_Elements_to_Hide":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility.Select_in_HTML_Elements_to_Hide_Sample_Code();
                    break;
                case "URI_Links_in_PDF":
                case "Convert_URI_Links":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Convert_URI_Links_to_PDF_Samples_Code();
                    break;
                case "Custom_URI_Links":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.URI_Links.Define_Custom_URI_Links_Sample_Code();
                    break;
                case "Internal_Links_in_PDF":
                case "Convert_Internal_Links":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Convert_Internal_Links_to_PDF_Sample_Code();
                    break;
                case "Custom_Internal_Links":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Internal_Links.Define_Custom_Internal_Links_Sample_Code();
                    break;
                case "File_Links_and_Attachments":
                case "Create_File_Links_and_Attachments":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.File_Links_Attachments.Create_File_Links_and_Atachments_Sample_Code();
                    break;
                case "Text_Notes":
                case "Create_Text_Notes":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Text_Notes.Create_Text_Notes_Sample_Code();
                    break;
                case "PDF_Actions":
                case "Execute_JavaScript_Open_Action":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Open_Action_Sample_Code();
                    break;
                case "Go_To_Page_Open_Action":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Go_To_Page_Open_Action_Sample_Code();
                    break;
                case "Execute_JavaScript_Button_Clicked":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Actions.Execute_JavaScript_Button_Clicked_Sample_Code();
                    break;
                case "Images_Quality":
                case "Images_Scaling_and_JPEG_Compression":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Images_Scaling_and_JPEG_Compression_Sample_Code();
                    break;
                case "Replace_Images":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality.Replace_with_Higher_Quality_Images_Sample_Code();
                    break;
                case "HTML_to_PDF_Elements":
                case "Add_HTML_to_PDF_Elements_to_PDF_Document":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_PDF_Elements.Add_HTML_to_PDF_Elements_to_PDF_Sample_Code();
                    break;
                case "HTML_to_Image_Elements":
                case "Add_HTML_to_Image_Elements_to_PDF_Document":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements.Add_HTML_to_Image_Elements_to_PDF_Sample_Code();
                    break;
                case "Flash_and_Extensions":
                case "Convert_HTML_with_Flash_to_PDF":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Flash_and_Extensions.Convert_HTML_with_Flash_to_PDF_Sample_Code();
                    break;
                case "Watermarks_and_Stamps":
                case "Add_Watermarks_and_Stamps":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.Watermarks_Stamps.Add_Watermarks_Stamps_Sample_Code();
                    break;
                case "PDF_Background_Foreground":
                case "Add_Elements_in_Background":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_in_Background_Sample_Code();
                    break;
                case "Add_Elements_Over_Main_Content":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background.Add_Elements_Over_Main_Content_Sample_Code();
                    break;
                case "PDF_Standards":
                case "Create_PDF_A_PDF_X_Documents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Standards.Create_PDF_A_and_PDF_X_Sample_Code();
                    break;
                case "PDF_Color_Spaces":
                case "Create_GrayScale_CMYK_Documents":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Color_Spaces.Create_GrayScale_CMYK_Sample_Code();
                    break;
                case "PDF_Viewer_Preferences":
                case "Set_Viewer_Preferences":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Viewer_Preferences_Sample_Code();
                    break;
                case "Set_Initial_Zoom_Level":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Sample_Code();
                    break;
                case "PDF_Security_Features":
                case "PDF_Permissions_and_Password":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.PDF_Permissions_and_Password_Sample_Code();
                    break;
                case "Digital_Signatures":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security.Digital_Signatures_Sample_Code();
                    break;
                case "HTTP_GET_and_POST":
                case "Access_Using_HTTP_GET_and_POST":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.GET_and_POST_HTTP_Methods_Sample_Code();
                    break;
                case "Proxy_Options":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.Proxy_Options_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.Proxy_Options_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST.Proxy_Options_Sample_Code();
                    break;
                case "HTTP_Headers_and_Cookies":
                case "Add_HTTP_Headers":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_HTTP_Headers_to_Request_Sample_Code();
                    break;
                case "Add_Cookies":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_Headers_and_Cookies.Add_Cookies_to_Request_Sample_Code();
                    break;
                case "HTML_to_Image":
                case "Convert_HTML_to_Image":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_Image.HTML_to_Image_Sample_Code();
                    break;
                case "HTML_to_SVG":
                case "Convert_HTML_to_SVG":
                    demoControl = new EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.HTML_to_SVG.HTML_to_SVG_Sample_Code();
                    break;
                case "PDF_Creator":
                case "Create_PDF_Documents":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Create_PDF_Documents_Sample_Code();
                    break;
                case "PDF_Creator_HTML_to_PDF_Elements":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_PDF_Elements_Sample_Code();
                    break;
                case "PDF_Creator_HTML_to_Image_Elements":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.HTML_to_Image_Elements_Sample_Code();
                    break;
                case "Text_Elements":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Elements_Sample_Code();
                    break;
                case "Graphic_Elements":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Graphic_Elements_Sample_Code();
                    break;
                case "Image_Elements":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Image_Elements_Sample_Code();
                    break;
                case "PDF_Creator_HTML_in_Header_Footer":
                case "PDF_Creator_Headers_and_Footers":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.HTML_in_Header_Footer_Sample_Code();
                    break;
                case "PDF_Creator_Page_Numbers_in_HTML":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Page_Numbers_in_HTML_Sample_Code();
                    break;
                case "PDF_Creator_Header_Footer_Auto_Resize":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Auto_Resize_Sample_Code();
                    break;
                case "PDF_Creator_Header_Footer_in_External_PDF":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_In_External_PDF_Sample_Code();
                    break;
                case "PDF_Creator_Header_Footer_Change_Per_Page":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers.Header_Footer_Change_Sample_Code();
                    break;
                case "Bookmarks":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Bookmarks_Sample_Code();
                    break;
                case "Create_PDF_Forms":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Forms_Sample_Code();
                    break;
                case "URI_Links":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.URI_Links_Sample_Code();
                    break;
                case "Internal_Links":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Internal_Links_Sample_Code();
                    break;
                case "File_Links":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Links_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Links_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Links_Sample_Code();
                    break;
                case "File_Attachments":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.File_Attachments_Sample_Code();
                    break;
                case "PDF_Creator_Text_Notes":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.Text_Notes_Sample_Code();
                    break;
                case "PDF_Creator_PDF_Actions":
                case "PDF_Creator_Execute_JavaScript_Open_Action":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Open_Action_Sample_Code();
                    break;
                case "PDF_Creator_Go_To_Page_Open_Action":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Go_To_Page_Open_Action_Sample_Code();
                    break;
                case "PDF_Creator_Execute_JavaScript_Button_Clicked":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions.Execute_JavaScript_Button_Clicked_Sample_Code();
                    break;
                case "PDF_Creator_PDF_Viewer_Preferences":
                case "PDF_Creator_Set_Viewer_Preferences":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Viewer_Preferences_Sample_Code();
                    break;
                case "PDF_Creator_Set_Initial_Zoom_Level":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences.Set_Initial_Zoom_Level_Sample_Code();
                    break;
                case "PDF_Creator_PDF_Security":
                case "PDF_Creator_PDF_Permissions_and_Password":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.PDF_Permissions_and_Password_Sample_Code();
                    break;
                case "PDF_Creator_Digital_Signatures":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Creator.PDF_Security.Digital_Signatures_Sample_Code();
                    break;
                case "Split_PDF":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Editor.Split_PDF_Sample_Code();
                    break;
                case "Merge_PDF":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Editor.Merge_PDF_Sample_Code();
                    break;
                case "PDF_Editor":
                case "Stamp_PDF_Documents":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Editor.Stamp_PDF_Sample_Code();
                    break;
                case "Fill_PDF_Forms":
                    demoControl = new EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Demo();
                    descriptionControl = new EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Description();
                    codeSampleControl = new EvoHtmlToPdfDemo.PDF_Editor.Fill_PDF_Forms_Sample_Code();
                    break;
                default:
                    demoControl = new Getting_Started_Demo();
                    descriptionControl = new Getting_Started_Description();
                    codeSampleControl = new Getting_Started_Sample_Code();
                    break;
            }

            if (demoControl != null)
            {
                demoControl.Dock = DockStyle.Fill;
                liveDemoTabPage.Controls.Add(demoControl);

                descriptionControl.Dock = DockStyle.Fill;
                descriptionTabPage.Controls.Add(descriptionControl);

                codeSampleControl.Dock = DockStyle.Fill;
                codeSampleTabPage.Controls.Add(codeSampleControl);
            }
        }

        private void collapseAllPictureBox_Click(object sender, EventArgs e)
        {
            CollapseAll();
        }
        
        private void expandAllPictureBox_Click(object sender, EventArgs e)
        {
            ExpandAll();
        }

        private void collapseAllLabel_Click(object sender, EventArgs e)
        {
            CollapseAll();
        }

        private void expandAllLabel_Click(object sender, EventArgs e)
        {
            ExpandAll();
        }

        private void bannerPicture_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.evopdf.com");
            }
            catch
            {}
        }
    }
}
