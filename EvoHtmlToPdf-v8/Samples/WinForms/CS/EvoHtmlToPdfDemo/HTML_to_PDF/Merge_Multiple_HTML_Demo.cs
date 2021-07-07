using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF
{
    public partial class Merge_Multiple_HTML_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create the PDF document where to add the HTML documents
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Create a PDF page where to add the first HTML
            PdfPage firstPdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Merge_Multipe_HTML.pdf";
            try
            {
                // Create the first HTML to PDF element
                HtmlToPdfElement firstHtml = new HtmlToPdfElement(0, 0, firstUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                firstHtml.ConversionDelay = 2;
                
                // Add the first HTML to PDF document
                AddElementResult firstAddResult = firstPdfPage.AddElement(firstHtml);

                PdfPage secondPdfPage = null;
                PointF secondHtmlLocation = Point.Empty;

                if (startNewPageCheckBox.Checked)
                {
                    // Create a PDF page where to add the second HTML
                    secondPdfPage = pdfDocument.AddPage();
                    secondHtmlLocation = PointF.Empty;
                }
                else
                {
                    // Add the second HTML on the PDF page where the first HTML ended
                    secondPdfPage = firstAddResult.EndPdfPage;
                    secondHtmlLocation = new PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom);
                }

                // Create the second HTML to PDF element
                HtmlToPdfElement secondHtml = new HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                secondHtml.ConversionDelay = 2;

                // Add the second HTML to PDF document
                secondPdfPage.AddElement(secondHtml);

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

        public Merge_Multiple_HTML_Demo()
        {
            InitializeComponent();
        }
    }
}
