using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Pages_Background
{
    public partial class Add_Elements_in_Background_Demo : UserControl
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

            // Set a handler for BeforeRenderPdfPageEvent where to set the background image in each PDF page before main content is rendered
            htmlToPdfConverter.BeforeRenderPdfPageEvent += new BeforeRenderPdfPageDelegate(htmlToPdfConverter_BeforeRenderPdfPageEvent);

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Add_Elements_in_Background.pdf";
            try
            {
                if (convertUrlRadioButton.Checked)
                {
                    string url = urlTextBox.Text;

                    // Convert the HTML page given by an URL to a PDF document in a memory buffer
                    byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(url);

                    // Write the memory buffer in a PDF file
                    System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
                }
                else
                {
                    string htmlString = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert a HTML string with a base URL to a PDF document in a memory buffer
                    byte[] outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlString, baseUrl);

                    // Write the memory buffer in a PDF file
                    System.IO.File.WriteAllBytes(outPdfFile, outPdfBuffer);
                }
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

                // Uninstall the handler
                htmlToPdfConverter.BeforeRenderPdfPageEvent -= new BeforeRenderPdfPageDelegate(htmlToPdfConverter_BeforeRenderPdfPageEvent);
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

        /// <summary>
        /// The BeforeRenderPdfPageEvent event handler where a background image is set in each PDF page
        /// before the main content is rendered
        /// </summary>
        /// <param name="eventParams">The event parameter containing the PDF page being rendered</param>
        void htmlToPdfConverter_BeforeRenderPdfPageEvent(BeforeRenderPdfPageParams eventParams)
        {
            if (!addBackgroundImageCheckBox.Checked)
                return;

            // Get the PDF page being rendered
            PdfPage pdfPage = eventParams.Page;

            // Get the PDF page drawable area width and height
            float pdfPageWidth = pdfPage.ClientRectangle.Width;
            float pdfPageHeight = pdfPage.ClientRectangle.Height;

            // The image to be added as background
            string backgroundImagePath = @"DemoAppFiles\Input\Images\background.jpg";

            // The image element to add in background
            ImageElement backgroundImageElement = new ImageElement(0, 0, pdfPageWidth, pdfPageHeight, backgroundImagePath);
            backgroundImageElement.KeepAspectRatio = true;
            backgroundImageElement.EnlargeEnabled = true;

            // Add the background image element to PDF page before the main content is rendered
            pdfPage.AddElement(backgroundImageElement);
        }

        private void convertUrlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlStringPanel.Visible = !convertUrlRadioButton.Checked;
        }

        private void convertHtmlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlStringPanel.Visible = !convertUrlRadioButton.Checked;
        }

        public Add_Elements_in_Background_Demo()
        {
            InitializeComponent();
        }
    }
}
