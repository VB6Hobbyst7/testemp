using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Images_Quality
{
    public partial class Replace_with_Higher_Quality_Images_Demo : UserControl
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

            // Select all images from HTML page
            htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = new string[] { "img" };

            // Exclude the original images from rendering becuase they will be replaced by an image from local file system
            htmlToPdfConverter.HiddenHtmlElementsSelectors = new string[] { "img" };

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Replace_with_Higher_Quality_Images.pdf";
            Document pdfDocument = null;
            try
            {
                // Convert a HTML string with images to replace to a PDF document object
                pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(urlTextBox.Text);

                // Replace the images selected in HTML using special attributes with images from local file system
                foreach (HtmlElementMapping imageElementInfo in htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult)
                {
                    PdfPage imagePdfPage = imageElementInfo.PdfRectangles[0].PdfPage;
                    RectangleF imageRectangle = imageElementInfo.PdfRectangles[0].Rectangle;

                    ImageElement newImageElement = new ImageElement(imageRectangle.X, imageRectangle.Y, imageRectangle.Width, imageRectangle.Height, 
                                    @"DemoAppFiles\Input\Images\box.jpg");
                    newImageElement.EnlargeEnabled = true;
                    imagePdfPage.AddElement(newImageElement);
                }

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

        private void viewHtmlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlTextBox.Text);
        }

        public Replace_with_Higher_Quality_Images_Demo()
        {
            InitializeComponent();
        }
    }
}
