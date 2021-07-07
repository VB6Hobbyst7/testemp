using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTTP_GET_and_POST
{
    public partial class GET_and_POST_HTTP_Methods_Demo : UserControl
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

            string param1Name = param1NameTextBox.Text.Length > 0 ? param1NameTextBox.Text : "param1";
            string param1Value = param1ValueTextBox.Text.Length > 0 ? param1ValueTextBox.Text : "Value 1";

            string param2Name = param2NameTextBox.Text.Length > 0 ? param2NameTextBox.Text : "param2";
            string param2Value = param2ValueTextBox.Text.Length > 0 ? param2ValueTextBox.Text : "Value 2";

            string param3Name = param3NameTextBox.Text.Length > 0 ? param3NameTextBox.Text : "param3";
            string param3Value = param3ValueTextBox.Text.Length > 0 ? param3ValueTextBox.Text : "Value 3";

            string param4Name = param4NameTextBox.Text.Length > 0 ? param4NameTextBox.Text : "param4";
            string param4Value = param4ValueTextBox.Text.Length > 0 ? param4ValueTextBox.Text : "Value 4";

            string param5Name = param5NameTextBox.Text.Length > 0 ? param5NameTextBox.Text : "param5";
            string param5Value = param5ValueTextBox.Text.Length > 0 ? param5ValueTextBox.Text : "Value 5";

            string urlToConvert = urlTextBox.Text;

            if (postMethodRadioButton.Checked)
            {
                htmlToPdfConverter.HttpPostFields.Add(param1Name, param1Value);
                htmlToPdfConverter.HttpPostFields.Add(param2Name, param2Value);
                htmlToPdfConverter.HttpPostFields.Add(param3Name, param3Value);
                htmlToPdfConverter.HttpPostFields.Add(param4Name, param4Value);
                htmlToPdfConverter.HttpPostFields.Add(param5Name, param5Value);
            }
            else
            {
                Uri getMethodUri = new Uri(urlTextBox.Text);
                
                string query = getMethodUri.Query.Length > 0 ? "&" : "?" + String.Format("{0}={1}", param1Name, param1Value);
                query += String.Format("&{0}={1}", param2Name, param2Value);
                query += String.Format("&{0}={1}", param3Name, param3Value);
                query += String.Format("&{0}={1}", param4Name, param4Value);
                query += String.Format("&{0}={1}", param5Name, param5Value);

                urlToConvert = urlTextBox.Text + query;
            }
            
            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\GET_and_POST.pdf";
            try
            {
                // Convert the HTML page to a PDF document in a memory buffer
                byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlToConvert);

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

        public GET_and_POST_HTTP_Methods_Demo()
        {
            InitializeComponent();
        }
    }
}
