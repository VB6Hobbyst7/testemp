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
    public partial class Set_Initial_Zoom_Level_Demo : UserControl
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

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Set_Initial_Zoom_Level.pdf";
            Document pdfDocument = null;
            try
            {
                // Convert a HTML page to a PDF document object
                pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text);

                int goToPageNumber = int.Parse(pageNumberTextBox.Text);
                if (goToPageNumber > pdfDocument.Pages.Count)
                {
                    MessageBox.Show("The page number is too big");
                    return;
                }

                // Get destination PDF page
                PdfPage goToPage = pdfDocument.Pages[goToPageNumber - 1];

                // Get the destination point in PDF page
                float goToX = float.Parse(xLocationTextBox.Text);
                float goToY = float.Parse(yLocationTextBox.Text);

                PointF goToLocation = new PointF(goToX, goToY);

                // Get the destination view mode
                DestinationViewMode viewMode = SelectedViewMode();

                // Create the destination in PDF document
                ExplicitDestination goToDestination = new ExplicitDestination(goToPage, goToLocation, viewMode);

                // Set the zoom level when the destination is displayed
                if (viewMode == DestinationViewMode.XYZ)
                    goToDestination.ZoomPercentage = int.Parse(zoomLevelTextBox.Text);

                // Set the document Go To open action
                pdfDocument.OpenAction.Action = new PdfActionGoTo(goToDestination);

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

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
                // Close the PDF document
                if (pdfDocument != null)
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

        private void Set_Initial_Zoom_Level_Demo_Load(object sender, EventArgs e)
        {
            viewModeComboBox.SelectedItem = "X, Y and Zoom";
        }
        
        private DestinationViewMode SelectedViewMode()
        {
            switch (viewModeComboBox.SelectedItem.ToString())
            {
                case "X, Y and Zoom":
                    return DestinationViewMode.XYZ;
                case "Fit Window":
                    return DestinationViewMode.Fit;
                case "Fit Horizontally":
                    return DestinationViewMode.FitH;
                case "Fit Vertically":
                    return DestinationViewMode.FitV;
                default:
                    return DestinationViewMode.XYZ;
            }
        }

        private void viewModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomLevelPanel.Visible = SelectedViewMode() == DestinationViewMode.XYZ;
        }

        public Set_Initial_Zoom_Level_Demo()
        {
            InitializeComponent();
        }
    }
}
