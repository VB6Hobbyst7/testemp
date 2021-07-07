using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.HTML_Elements_Location
{
    public partial class Select_in_HTML_Elements_to_Retrieve_Demo : UserControl
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

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Select_in_HTML_Elements_to_Retrieve.pdf";
            Document pdfDocument = null;
            try
            {
                // Convert HTML page or string with mapping attributes to a PDF document object 
                // The document can be further modified to highlight the selected elements
                if (convertHtmlRadioButton.Checked)
                {
                    string htmlWithMappingAttributes = htmlStringTextBox.Text;
                    string baseUrl = baseUrlTextBox.Text;

                    // Convert a HTML string with mapping attributes to a PDF document object
                    pdfDocument = htmlToPdfConverter.ConvertHtmlToPdfDocumentObject(htmlWithMappingAttributes, baseUrl);
                }
                else
                {
                    string url = urlTextBox.Text;

                    // Convert a HTML page with mapping attributes to a PDF document object
                    pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(url);
                }

                // Display detailed information about the selected elements
                StringBuilder htmlElementInfoBuilder = new StringBuilder();
                foreach (HtmlElementMapping htmlElementInfo in htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult)
                {
                    // Get other information about HTML element
                    string htmlElementTagName = htmlElementInfo.HtmlElementTagName;
                    string htmlElementID = htmlElementInfo.HtmlElementId;
                    string htmlElementMappingID = htmlElementInfo.MappingId; 
                    string htmlElementCssClasssName = htmlElementInfo.HtmlElementCssClassName;
                    string htmlElementHtmlCode = htmlElementInfo.HtmlElementOuterHtml;
                    string htmlElementInnerHtml = htmlElementInfo.HtmlElementInnerHtml;
                    string htmlElementText = htmlElementInfo.HtmlElementText;
                    System.Collections.Specialized.NameValueCollection htmlElementAttributes = htmlElementInfo.HtmlElementAttributes;
                    HtmlElementPdfRectangle[] htmlElementRectanglesInPdf = htmlElementInfo.PdfRectangles;

                    htmlElementInfoBuilder.AppendFormat("<br/>---------------------------------------- HTML Element Info ----------------------------------------<br/><br/>");
                    htmlElementInfoBuilder.AppendFormat("<b>Tag Name:</b> {0}<br/>", htmlElementTagName);
                    htmlElementInfoBuilder.AppendFormat("<b>Element ID:</b> {0}<br/>", htmlElementID);  
                    htmlElementInfoBuilder.AppendFormat("<b>Mapping ID:</b> {0}<br/>", htmlElementMappingID);
                    htmlElementInfoBuilder.AppendFormat("<b>Text:</b> {0}<br/>", htmlElementText);

                    htmlElementInfoBuilder.AppendFormat("<b>Attributes:</b><br/>");
                    for (int i = 0; i < htmlElementAttributes.Count; i++)
                        htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;{0} = \"{1}\"<br/>", htmlElementAttributes.GetKey(i), htmlElementAttributes.Get(i));


                    htmlElementInfoBuilder.AppendFormat("<b>Location in PDF:</b><br/>");
                    for (int i = 0; i < htmlElementRectanglesInPdf.Length; i++)
                    {
                        PdfPage pdfPage = htmlElementRectanglesInPdf[i].PdfPage;
                        int pdfPageIndex = htmlElementRectanglesInPdf[i].PageIndex;
                        RectangleF rectangleInPdfPage = htmlElementRectanglesInPdf[i].Rectangle;

                        htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;PDF Page Index: {0}<br>", pdfPageIndex);
                        htmlElementInfoBuilder.AppendFormat("&nbsp;&nbsp;&nbsp;Rectangle: X = {0:N2} pt , Y = {1:N2} pt , W = {2:N2} pt , H = {3:N2} pt<br/>",
                                rectangleInPdfPage.X, rectangleInPdfPage.Y, rectangleInPdfPage.Width, rectangleInPdfPage.Height);
                    }

                    htmlElementInfoBuilder.AppendFormat("<br/>");
                }

                PdfPage lastPdfPage = htmlToPdfConverter.ConversionSummary.LastPdfPage;
                RectangleF lastPageRectangle = htmlToPdfConverter.ConversionSummary.LastPageRectangle;

                HtmlToPdfElement htmlElementInfoHtml = new HtmlToPdfElement(0, lastPageRectangle.Bottom + 1, htmlElementInfoBuilder.ToString(), null);
                lastPdfPage.AddElement(htmlElementInfoHtml);

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();

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
                // Close the PDF document
                if (pdfDocument != null)
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

        private void Select_in_HTML_Elements_to_Retrieve_Demo_Load(object sender, EventArgs e)
        {
            htmlStringTextBox.Text = System.IO.File.ReadAllText(@"DemoAppFiles\Input\HTML_Files\HTML_Elements_Info.html");
            baseUrlTextBox.Text = "file:///" + Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files/";

            urlTextBox.Text = Application.StartupPath + @"\DemoAppFiles\Input\HTML_Files\HTML_Elements_Info.html";
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

        public Select_in_HTML_Elements_to_Retrieve_Demo()
        {
            InitializeComponent();
        }
    }
}
