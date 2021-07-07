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
    public partial class Merge_With_Existing_PDF_Demo : UserControl
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

            // Set the PDF file to be inserted before conversion result
            htmlToPdfConverter.PdfDocumentOptions.AddStartDocument(pdfBeforeTextBox.Text);

            // Set the PDF file to be added after conversion result
            htmlToPdfConverter.PdfDocumentOptions.AddEndDocument(pdfAfterTextBox.Text);

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Merge_HTML_with_Existing_PDF.pdf";
            try
            {
                // The URL to convert
                string url = urlTextBox.Text;

                // Convert the HTML page to a PDF document and add the external PDF documents
                byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(url);

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

        private void Merge_With_Existing_PDF_Demo_Load(object sender, EventArgs e)
        {
            pdfBeforeTextBox.Text = @"DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf";
            pdfAfterTextBox.Text = @"DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf";
        }

        public Merge_With_Existing_PDF_Demo()
        {
            InitializeComponent();
        }
    }
}
