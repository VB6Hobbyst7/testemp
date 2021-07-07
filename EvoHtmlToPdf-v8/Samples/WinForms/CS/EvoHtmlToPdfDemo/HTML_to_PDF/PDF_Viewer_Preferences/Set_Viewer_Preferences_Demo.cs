using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Viewer_Preferences
{
    public partial class Set_Viewer_Preferences_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2;

            // Set the PDF Viewer Preferences

            // Set page layout to continuous one column, single page, two column left, two column right
            htmlToPdfConverter.PdfViewerPreferences.PageLayout = SelectedPageLayout();
            // Set page mode to default, display bookmarks, display thumbnails, display attachments
            htmlToPdfConverter.PdfViewerPreferences.PageMode = SelectedPageMode();

            // Hide the viewer menu
            htmlToPdfConverter.PdfViewerPreferences.HideMenuBar = hideMenuBarCheckBox.Checked;
            // Hide the viewer toolbar
            htmlToPdfConverter.PdfViewerPreferences.HideToolbar = hideToolbarCheckBox.Checked;
            // Hide scroll bars and navigation controls
            htmlToPdfConverter.PdfViewerPreferences.HideWindowUI = hideWindowUICheckBox.Checked;
            
            // Display the document title in viewer title bar
            htmlToPdfConverter.PdfViewerPreferences.DisplayDocTitle = displayDocTitleCheckBox.Checked;
            
            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Set_PDF_Viewer_Preferences.pdf";
            try
            {
                // Convert the HTML page to a PDF document in a memory buffer
                byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlTextBox.Text);

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The HTML to PDF conversion failed
                MessageBox.Show(String.Format("HTML to PDF Error. {0}", ex.Message));
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // Open the created PDF document in default PDF viewer
            try
            {
                System.Diagnostics.Process.Start(outPdfFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", outPdfFile, ex.Message));
            }
        }

        private void Set_Viewer_Preferences_Demo_Load(object sender, EventArgs e)
        {
            pageLayoutComboBox.SelectedItem = "One Column";
            pageModeComboBox.SelectedItem = "Default";
        }

        private ViewerPageLayout SelectedPageLayout()
        {
            switch (pageLayoutComboBox.SelectedItem.ToString())
            {
                case "Single Page":
                    return ViewerPageLayout.SinglePage;
                case "One Column":
                    return ViewerPageLayout.OneColumn;
                case "Two Column Left":
                    return ViewerPageLayout.TwoColumnLeft;
                case "Two Column Right":
                    return ViewerPageLayout.TwoColumnRight;
                default:
                    return ViewerPageLayout.OneColumn;
            }
        }

        private ViewerPageMode SelectedPageMode()
        {
            switch (pageModeComboBox.SelectedItem.ToString())
            {
                case "Default":
                    return ViewerPageMode.UseNone;
                case "Display Outlines":
                    return ViewerPageMode.UseOutlines;
                case "Display Thumbnails":
                    return ViewerPageMode.UseThumbs;
                case "Display Full Screen":
                    return ViewerPageMode.FullScreen;
                case "Display Optional Content Group":
                    return ViewerPageMode.UseOC;
                case "Display Attachments":
                    return ViewerPageMode.UseAttachments;
                default:
                    return ViewerPageMode.UseNone;
            }
        }

        public Set_Viewer_Preferences_Demo()
        {
            InitializeComponent();
        }
    }
}
