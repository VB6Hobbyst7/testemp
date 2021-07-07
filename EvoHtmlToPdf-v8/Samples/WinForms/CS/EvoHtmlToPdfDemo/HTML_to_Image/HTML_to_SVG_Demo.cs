using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_SVG
{
    public partial class HTML_to_SVG_Demo : UserControl
    {
        private void convertToSvgButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to SVG converter object with default settings
            HtmlToSvgConverter htmlToSvgConverter = new HtmlToSvgConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToSvgConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
            htmlToSvgConverter.HtmlViewerWidth = int.Parse(htmlViewerWidthTextBox.Text);

            // Set HTML viewer height in pixels to convert the top part of a HTML page 
            // Leave it not set to convert the entire HTML
            if (htmlViewerHeightTextBox.Text.Length > 0)
                htmlToSvgConverter.HtmlViewerHeight = int.Parse(htmlViewerHeightTextBox.Text);
            
            // Set the maximum time in seconds to wait for HTML page to be loaded 
            // Leave it not set for a default 60 seconds maximum wait time
            htmlToSvgConverter.NavigationTimeout = int.Parse(navigationTimeoutTextBox.Text);

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            if (conversionDelayTextBox.Text.Length > 0)
                htmlToSvgConverter.ConversionDelay = int.Parse(conversionDelayTextBox.Text);

            Cursor = Cursors.WaitCursor;

            // Convert HTML to SVG using the settings above
            string outSvgFile = @"DemoAppFiles\Output\HTML_to_Image\HTML_to_SVG.svg";
            try
            {
                if (convertUrlRadioButton.Checked)
                {
                    string url = urlTextBox.Text;

                    // Convert the HTML page given by an URL to a SVG document in a memory buffer
                    byte[] outSvgBuffer = htmlToSvgConverter.ConvertUrl(url);

                    // Write the memory buffer in a SVG file
                    System.IO.File.WriteAllBytes(outSvgFile, outSvgBuffer);
                }
                else
                {
                    string htmlString = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert a HTML string with a base URL to a SVG document in a memory buffer
                    byte[] outSvgBuffer = htmlToSvgConverter.ConvertHtml(htmlString, baseUrl);

                    // Write the memory buffer in a SVG file
                    System.IO.File.WriteAllBytes(outSvgFile, outSvgBuffer);
                }
            }
            catch (Exception ex)
            {
                // The HTML to SVG conversion failed
                MessageBox.Show(String.Format("HTML to SVG Error. {0}", ex.Message));
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // Open the created SVG file in the default SVG viewer
            try
            {
                System.Diagnostics.Process.Start(outSvgFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created SVG file '{0}'. {1}", outSvgFile, ex.Message));
            }
        }

        private void HTML_to_SVG_Demo_Load(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlStringPanel.Visible = !convertUrlRadioButton.Checked;
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

        public HTML_to_SVG_Demo()
        {
            InitializeComponent();
        }
    }
}
