using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Creator.Headers_and_Footers
{
    public partial class Page_Numbers_in_HTML_Demo : UserControl
    {
        private void createPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Add a PDF page to PDF document
            PdfPage pdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Page_Numbers_in_HTML.pdf";
            try
            {
                // Create the document footer template
                pdfDocument.AddFooterTemplate(50);

                // ----- Add HTML with Page Numbering to Footer -----

                // Create a variable HTML element with page numbering
                string htmlStringWithPageNumbers = htmlWithPageNumbersTextBox.Text;
                string baseUrl = baseUrlTextBox.Text;
                HtmlToPdfVariableElement footerHtmlWithPageNumbers = new HtmlToPdfVariableElement(htmlStringWithPageNumbers, baseUrl);

                // Set the HTML element to fit the container height
                footerHtmlWithPageNumbers.FitHeight = true;

                // Add variable HTML element with page numbering to footer
                pdfDocument.Footer.AddElement(footerHtmlWithPageNumbers);

                // Optionally draw a line at the top of the footer
                if (drawFooterLineCheckBox.Checked)
                {
                    float footerWidth = pdfDocument.Footer.Width;

                    // Create a line element for the top of the footer
                    LineElement footerLine = new LineElement(0, 0, footerWidth, 0);

                    // Set line color
                    footerLine.ForeColor = Color.Gray;

                    // Add line element to the bottom of the footer
                    pdfDocument.Footer.AddElement(footerLine);
                }

                // Create a HTML to PDF element to add to document
                HtmlToPdfElement htmlToPdfElement = new HtmlToPdfElement(0, 0, urlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToPdfElement.ConversionDelay = 2;
                
                // Optionally add a space between footer and the page body
                // Leave this option not set for no spacing
                htmlToPdfElement.BottomSpacing = float.Parse(footerSpacingTextBox.Text);

                // Add the HTML to PDF element to document
                // This will raise the PrepareRenderPdfPageEvent event where the header and footer visibilit per page can be changed
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
