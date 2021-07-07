using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_to_Image_Elements
{
    public partial class Add_HTML_to_Image_Elements_to_PDF_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Create a PDF page where to add the first HTML
            PdfPage firstPdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Add_HTML_to_Image_Elements_to_PDF.pdf";
            try
            {
                // The image location in PDF
                float xLocation = float.Parse(xLocationTextBox.Text);
                float yLocation = float.Parse(yLocationTextBox.Text);

                // The URL of the HTML page to convert to an image in PDF
                string urlToConvert = urlTextBox.Text;

                // Create the HTML to Image element
                HtmlToImageElement htmlToImageElement = new HtmlToImageElement(xLocation, yLocation, urlToConvert);

                // Optionally set the HTML viewer width
                htmlToImageElement.HtmlViewerWidth = int.Parse(htmlViewerWidthTextBox.Text);

                // Optionally set the HTML viewer height
                if (htmlViewerHeightTextBox.Text.Length > 0)
                    htmlToImageElement.HtmlViewerHeight = int.Parse(htmlViewerHeightTextBox.Text);

                // Optionally set the HTML content clipping option to force the HTML content width to be exactly HtmlViewerWidth pixels
                htmlToImageElement.ClipHtmlView = clipContentCheckBox.Checked;

                // Optionally set the destination width in PDF
                if (contentWidthTextBox.Text.Length > 0)
                    htmlToImageElement.Width = float.Parse(contentWidthTextBox.Text);                

                // Optionally set the destination height in PDF
                if (contentHeightTextBox.Text.Length > 0)
                    htmlToImageElement.Height = float.Parse(contentHeightTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToImageElement.ConversionDelay = 2;

                // Add the HTML to Image element to PDF document
                // The AddElementResult contains the bounds of the HTML to Image Element in last rendered PDF page
                // such that you can start a new PDF element right under it
                AddElementResult result = firstPdfPage.AddElement(htmlToImageElement);

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

        public Add_HTML_to_Image_Elements_to_PDF_Demo()
        {
            InitializeComponent();
        }
    }
}
