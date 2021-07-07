using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Viewer_Preferences
{
    public partial class Set_Viewer_Preferences_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Add a page to PDF document
            PdfPage pdfPage = pdfDocument.AddPage();

            // Set the PDF Viewer Preferences

            // Set page layout to continuous one column, single page, two column left, two column right
            pdfDocument.ViewerPreferences.PageLayout = SelectedPageLayout();
            // Set page mode to default, display attachments, display thumbnails, display attachments
            pdfDocument.ViewerPreferences.PageMode = SelectedPageMode();

            // Hide the viewer menu
            pdfDocument.ViewerPreferences.HideMenuBar = hideMenuBarCheckBox.Checked;
            // Hide the viewer toolbar
            pdfDocument.ViewerPreferences.HideToolbar = hideToolbarCheckBox.Checked;
            // Hide scroll bars and navigation controls
            pdfDocument.ViewerPreferences.HideWindowUI = hideWindowUICheckBox.Checked;
            
            // Display the document title in viewer title bar
            pdfDocument.ViewerPreferences.DisplayDocTitle = displayDocTitleCheckBox.Checked;
            
            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Set_PDF_Viewer_Preferences.pdf";
            try
            {
                // Create a HTML to PDF element to add to document
                HtmlToPdfElement htmlToPdfElement = new HtmlToPdfElement(urlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToPdfElement.ConversionDelay = 2;

                // Add the HTML to PDF element to document
                pdfPage.AddElement(htmlToPdfElement);

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
            }
            catch (Exception ex)
            {
                // The PDF creation failed
                MessageBox.Show(String.Format("Create PDF Document Error. {0}", ex.Message));
                return;
            }
            finally
            {
                // Close the PDF document
                pdfDocument.Close();

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
