using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Actions
{
    public partial class Execute_JavaScript_Button_Clicked_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create a PDF document
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";
            
            // Add a page to PDF document
            PdfPage pdfPage = pdfDocument.AddPage();

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Button_JavaScript_Actions.pdf";
            try
            {
                string htmlWithButton = htmlStringTextBox.Text;
                string baseUrl = baseUrlTextBox.Text;

                // Add a HTML string with a button to PDF document
                HtmlToPdfElement htmlToPdfElement = new HtmlToPdfElement(htmlWithButton, baseUrl);
                pdfPage.AddElement(htmlToPdfElement);
                
                // Get the button location in PDF
                HtmlElementMapping buttonMapping = htmlToPdfElement.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByMappingId("javascript_button");
                if (buttonMapping != null)
                {
                    PdfPage buttonPdfPage = buttonMapping.PdfRectangles[0].PdfPage;
                    RectangleF buttonRectangle = buttonMapping.PdfRectangles[0].Rectangle;
                    
                    // The font used for buttons text in PDF document
                    PdfFont buttonTextFont = pdfDocument.AddFont(new Font("Times New Roman", 8, FontStyle.Regular, GraphicsUnit.Point));

                    // Create a PDF form button
                    PdfFormButton pdfButton = pdfDocument.Form.AddButton(buttonPdfPage, buttonRectangle, "Execute Acrobat JavaScript", buttonTextFont);

                    // Set JavaScript action to be executed when the button is clicked
                    string javaScript = null;
                    if (alertMessageRadioButton.Checked)
                    {
                        // JavaScript to display an alert mesage 
                        javaScript = String.Format("app.alert(\"{0}\")", alertMessageTextBox.Text);
                    }
                    else if (printDialogRadioButton.Checked)
                    {
                        // JavaScript to open the print dialog
                        javaScript = "print()";
                    }
                    else if (zoomLevelRadioButton.Checked)
                    {
                        // JavaScript to set an initial zoom level 
                        javaScript = String.Format("zoom={0}", int.Parse(zoomLevelTextBox.Text));
                    }

                    // Set the JavaScript action
                    pdfButton.Action = new PdfActionJavaScript(javaScript);
                }

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

        private void Execute_JavaScript_Button_Clicked_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\Button_JavaScript_Actions.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";
        }

        private void alertMessageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            zoomLevelPanel.Visible = zoomLevelRadioButton.Checked;
            alertMessagePanel.Visible = alertMessageRadioButton.Checked;
        }

        private void printDialogRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            zoomLevelPanel.Visible = zoomLevelRadioButton.Checked;
            alertMessagePanel.Visible = alertMessageRadioButton.Checked;
        }

        private void zoomLevelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            zoomLevelPanel.Visible = zoomLevelRadioButton.Checked;
            alertMessagePanel.Visible = alertMessageRadioButton.Checked;
        }

        public Execute_JavaScript_Button_Clicked_Demo()
        {
            InitializeComponent();
        }
    }
}
