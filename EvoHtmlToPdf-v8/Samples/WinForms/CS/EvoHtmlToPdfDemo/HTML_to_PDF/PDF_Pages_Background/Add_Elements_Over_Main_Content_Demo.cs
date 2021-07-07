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
    public partial class Add_Elements_Over_Main_Content_Demo : UserControl
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

            // Set a handler for AfterRenderPdfPageEvent where to add the stamp in each PDF page over the main content
            htmlToPdfConverter.AfterRenderPdfPageEvent += new AfterRenderPdfPageDelegate(htmlToPdfConverter_AfterRenderPdfPageEvent);

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Add_Elements_Over_Main_Content.pdf";
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
                htmlToPdfConverter.AfterRenderPdfPageEvent -= new AfterRenderPdfPageDelegate(htmlToPdfConverter_AfterRenderPdfPageEvent);
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

        void htmlToPdfConverter_AfterRenderPdfPageEvent(AfterRenderPdfPageParams eventParams)
        {
            if (!addStampCheckBox.Checked)
                return;

            // Get the rendered PDF page
            PdfPage pdfPage = eventParams.Page;

            int pageNumber = eventParams.PageNumber;
            int pageCount = eventParams.PageCount;
            bool isOddPage = pageNumber % 2 != 0;

            // Get the PDF document
            Document pdfDocument = pdfPage.Document;

            // Get the PDF page drawable area width and height
            float pdfPageWidth = pdfPage.ClientRectangle.Width;
            float pdfPageHeight = pdfPage.ClientRectangle.Height;

            // Create a .NET font
            Font timesNewRomanFont = new Font("Times New Roman", 50, GraphicsUnit.Point);

            // Create a PDF font
            PdfFont pdfFont = pdfDocument.AddFont(timesNewRomanFont, true);

            // The stamp text
            string text = String.Format("Stamp on Page {0} of {1}", pageNumber, pageCount);

            // Measure the text 
            float textWidth = pdfFont.GetTextWidth(text);

            // Calculate the PDF page diagonal
            float pdfPageDiagonal = (float)Math.Sqrt(pdfPageWidth*pdfPageWidth + pdfPageHeight*pdfPageHeight);

            // The text location on PDF page diagonal
            float xLocation = (pdfPageDiagonal - textWidth) / 2;

            // Create the stamp as a rotated text element
            TextElement stampTextElement = new TextElement(xLocation, 0, text, pdfFont);
            stampTextElement.ForeColor = isOddPage ? Color.Blue : Color.Green;
            stampTextElement.Rotate((float)(Math.Atan(pdfPageHeight / pdfPageWidth) * (180 / Math.PI)));
            stampTextElement.Opacity = 75;

            // Add the stamp to PDF page
            pdfPage.AddElement(stampTextElement);
        }

        public Add_Elements_Over_Main_Content_Demo()
        {
            InitializeComponent();
        }
    }
}
