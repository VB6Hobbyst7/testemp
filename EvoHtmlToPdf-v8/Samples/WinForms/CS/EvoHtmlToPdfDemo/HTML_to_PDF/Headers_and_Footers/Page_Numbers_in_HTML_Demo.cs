using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Headers_and_Footers  
{
    public partial class Page_Numbers_in_HTML_Demo : UserControl
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
            
            // Enable footer in the generated PDF document
            htmlToPdfConverter.PdfDocumentOptions.ShowFooter = true;

            // Optionally add a space between footer and the page body
            // Leave this option not set for no spacing
            htmlToPdfConverter.PdfDocumentOptions.BottomSpacing = float.Parse(footerSpacingTextBox.Text);

            // Set the footer height in points
            htmlToPdfConverter.PdfFooterOptions.FooterHeight = 50;

            // ----- Add HTML with Page Numbering to Footer -----

            // Create a variable HTML element with page numbering
            string htmlStringWithPageNumbers = htmlWithPageNumbersTextBox.Text;
            string baseUrl = baseUrlTextBox.Text;
            HtmlToPdfVariableElement footerHtmlWithPageNumbers = new HtmlToPdfVariableElement(htmlStringWithPageNumbers, baseUrl);

            // Set the HTML element to fit the container height
            footerHtmlWithPageNumbers.FitHeight = true;

            // Add variable HTML element with page numbering to footer
            htmlToPdfConverter.PdfFooterOptions.AddElement(footerHtmlWithPageNumbers);

            // Optionally draw a line at the top of the footer
            if (drawFooterLineCheckBox.Checked)
            {
                // Calculate the footer width based on PDF page size and margins
                float footerWidth = htmlToPdfConverter.PdfDocumentOptions.PdfPageSize.Width -
                            htmlToPdfConverter.PdfDocumentOptions.LeftMargin - htmlToPdfConverter.PdfDocumentOptions.RightMargin;
                
                // Create a line element for the top of the footer
                LineElement footerLine = new LineElement(0, 0, footerWidth, 0);

                // Set line color
                footerLine.ForeColor = Color.Gray;

                // Add line element to the bottom of the footer
                htmlToPdfConverter.PdfFooterOptions.AddElement(footerLine);
            }

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Page_Numbers_in_HTML.pdf";
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

        private void Page_Numbers_in_HTML_Demo_Load(object sender, EventArgs e)
        {
            string htmlWithPageNumbers = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\Page_Numbers_in_HTML.html");

            htmlWithPageNumbersTextBox.Text = htmlWithPageNumbers;
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";
        }

        public Page_Numbers_in_HTML_Demo()
        {
            InitializeComponent();
        }
    }
}
