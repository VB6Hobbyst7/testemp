using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_Image
{
    public partial class HTML_to_Image_Demo : UserControl
    {
        private void convertToImageButton_Click(object sender, EventArgs e)
        {
            // Create a HTML to Image converter object with default settings
            HtmlToImageConverter htmlToImageConverter = new HtmlToImageConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToImageConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set HTML Viewer width in pixels which is the equivalent in converter of the browser window width
            htmlToImageConverter.HtmlViewerWidth = int.Parse(htmlViewerWidthTextBox.Text);

            // Set HTML viewer height in pixels to convert the top part of a HTML page 
            // Leave it not set to convert the entire HTML
            if (htmlViewerHeightTextBox.Text.Length > 0)
                htmlToImageConverter.HtmlViewerHeight = int.Parse(htmlViewerHeightTextBox.Text);

            // Set if the created image has a transparent background
            htmlToImageConverter.TransparentBackground = SelectedImageFormat() == System.Drawing.Imaging.ImageFormat.Png ? transparentBackgroundCheckBox.Checked : false;
            
            // Set the maximum time in seconds to wait for HTML page to be loaded 
            // Leave it not set for a default 60 seconds maximum wait time
            htmlToImageConverter.NavigationTimeout = int.Parse(navigationTimeoutTextBox.Text);

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            if (conversionDelayTextBox.Text.Length > 0)
                htmlToImageConverter.ConversionDelay = int.Parse(conversionDelayTextBox.Text);

            Cursor = Cursors.WaitCursor;

            // Convert HTML to Image using the settings above
            string outImageFile = @"DemoAppFiles\Output\HTML_to_Image\HTML_to_Image." + imageFormatComboBox.SelectedItem.ToString().ToLower();
            Image[] imageTiles = null;
            try
            {
                if (convertUrlRadioButton.Checked)
                {
                    string url = urlTextBox.Text;

                    // Convert the HTML page given by an URL to a set of Image objects
                    imageTiles = htmlToImageConverter.ConvertUrlToImageTiles(url);
                }
                else
                {
                    string htmlString = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert a HTML string with a base URL to a set of Image objects
                    imageTiles = htmlToImageConverter.ConvertHtmlToImageTiles(htmlString, baseUrl);
                }

                // Save the first image tile to a memory buffer

                Image outImage = imageTiles[0];

                // Create a memory stream where to save the image
                System.IO.MemoryStream imageOutputStream = new System.IO.MemoryStream();

                // Save the image to memory stream
                outImage.Save(imageOutputStream, SelectedImageFormat());

                // Write the memory stream to a memory buffer
                imageOutputStream.Position = 0;
                byte[] outImageBuffer = imageOutputStream.ToArray();

                // Close the output memory stream
                imageOutputStream.Close();

                // Write the memory buffer in an image file
                System.IO.File.WriteAllBytes(outImageFile, outImageBuffer);
            }
            catch (Exception ex)
            {
                // The HTML to Image conversion failed
                MessageBox.Show(String.Format("HTML to Image Error. {0}", ex.Message));
                return;
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }

            // Open the created image in the default viewer for image format
            try
            {
                System.Diagnostics.Process.Start(outImageFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created image file '{0}'. {1}", outImageFile, ex.Message));
            }
        }

        private System.Drawing.Imaging.ImageFormat SelectedImageFormat()
        {
            switch (imageFormatComboBox.SelectedItem.ToString())
            {
                case "Png":
                    return System.Drawing.Imaging.ImageFormat.Png;
                case "Jpg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case "Bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;
                default:
                    return System.Drawing.Imaging.ImageFormat.Png;
            }
        }

        private void HTML_to_Image_Demo_Load(object sender, EventArgs e)
        {
            urlPanel.Visible = convertUrlRadioButton.Checked;
            htmlStringPanel.Visible = !convertUrlRadioButton.Checked;

            imageFormatComboBox.SelectedItem = "Png";
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

        private void imageFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transparentBackgroundCheckBox.Visible = SelectedImageFormat() == System.Drawing.Imaging.ImageFormat.Png;
        }

        public HTML_to_Image_Demo()
        {
            InitializeComponent();
        }
    }
}
