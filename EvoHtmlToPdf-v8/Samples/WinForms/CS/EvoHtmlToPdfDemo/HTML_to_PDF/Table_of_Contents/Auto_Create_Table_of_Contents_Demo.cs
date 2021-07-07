using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.Table_of_Contents
{
    public partial class Auto_Create_Table_of_Contents_Demo : UserControl
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

            // Enable the creation of a table of contents from H1 to H6 tags found in HTML
            htmlToPdfConverter.TableOfContentsOptions.AutoTocItemsEnabled = autoTableOfContentsCheckBox.Checked;

            // Optionally set the table of contents title
            htmlToPdfConverter.TableOfContentsOptions.Title = "Table of Contents";

            // Optionally set the title style using CSS sttributes
            htmlToPdfConverter.TableOfContentsOptions.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal";

            // Optionally set the style of level 1 items in table of contents
            string level1TextStyle = "color:black; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0";
            htmlToPdfConverter.TableOfContentsOptions.SetItemStyle(1, level1TextStyle);

            // Optionally set the page numbers style of level 1 items in table of contents
            string level1PageNumberStyle = "color:black; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold";
            htmlToPdfConverter.TableOfContentsOptions.SetPageNumberStyle(1, level1PageNumberStyle);

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Auto_Create_Table_of_Contents.pdf";
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

        private void viewHtmlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(urlTextBox.Text);
        }

        public Auto_Create_Table_of_Contents_Demo()
        {
            InitializeComponent();
        }
    }
}
