using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Page_Breaks
{
    public partial class Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Demo : UserControl
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

            // Set the CSS selectors of the HTML elements for which to avoid page breaks inside in the generated PDF document
            htmlToPdfConverter.PdfDocumentOptions.AvoidHtmlElementsBreakSelectors = new string[] { htmlElementsSelectorTextBox.Text };

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Avoid_Page_Breaks_Inside_HTML_Elements_Using_API.pdf";
            try
            {
                byte[] outPdfBuffer = null;

                if (convertHtmlRadioButton.Checked)
                {
                    string htmlWithForm = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert the HTML string to a PDF document in a memory buffer
                    outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithForm, baseUrl);
                }
                else
                {
                    string url = urlTextBox.Text;

                    // Convert the HTML page to a PDF document in a memory buffer
                    outPdfBuffer = htmlToPdfConverter.ConvertUrl(url);
                }

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

        private void Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\Page_Breaks_Inside_Avoid_Using_API.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";

            urlTextBox.Text = System.IO.Path.Combine(Application.StartupPath, @"DemoAppFiles\Input\HTML_Files\Page_Breaks_Inside_Avoid_Using_API.html");
        }

        private void convertHtmlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlPanel.Visible = !convertUrlRadioButton.Checked;
        }

        private void convertUrlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlPanel.Visible = !convertUrlRadioButton.Checked;
        }

        private void viewHtmlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlTextBox.Text);
        }

        public Avoid_Page_Breaks_Inside_HTML_Elements_Using_API_Demo()
        {
            InitializeComponent();
        }
    }
}
