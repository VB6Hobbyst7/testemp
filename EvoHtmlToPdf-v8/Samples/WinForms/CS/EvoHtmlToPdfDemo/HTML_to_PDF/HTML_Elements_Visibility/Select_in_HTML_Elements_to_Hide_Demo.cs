﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Visibility
{
    public partial class Select_in_HTML_Elements_to_Hide_Demo : UserControl
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
            
            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Select_in_HTML_Elements_to_Hide.pdf";
            try
            {
                byte[] outPdfBuffer = null;

                if (convertHtmlRadioButton.Checked)
                {
                    string htmlWithBookmarkAttributes = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert a HTML string with exclude attributes to a PDF document in a memory buffer
                    outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithBookmarkAttributes, baseUrl);
                }
                else
                {
                    string url = urlTextBox.Text;

                    // Convert a HTML page with exclude attributes to a PDF document in a memory buffer
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

        private void Select_in_HTML_Elements_to_Hide_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\HTML_Elements_to_Hide.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";

            urlTextBox.Text = Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files\HTML_Elements_to_Hide.html";
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

        public Select_in_HTML_Elements_to_Hide_Demo()
        {
            InitializeComponent();
        }
    }
}
