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
    public partial class Merge_Table_of_Contents_Demo : UserControl
    {
        private void convertToPdfButton_Click(object sender, EventArgs e)
        {
            // Create the PDF document where to add the HTML documents
            Document pdfDocument = new Document();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            pdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Create a PDF page where to add the first HTML
            PdfPage firstPdfPage = pdfDocument.AddPage();

            // Enable the creation of a table of contents from H1 to H6 tags found in HTML
            pdfDocument.TableOfContents.AutoTocItemsEnabled = autoTableOfContentsCheckBox.Checked;

            // Optionally set the table of contents title
            pdfDocument.TableOfContents.Title = "Table of Contents";

            // Optionally set the title style using CSS sttributes
            pdfDocument.TableOfContents.TitleStyle = "color:navy; font-family:'Times New Roman'; font-size:28px; font-weight:normal";

            // Optionally set the style of level 1 items in table of contents
            string level1TextStyle = "color:black; font-family:'Times New Roman'; font-size:20px; font-weight:normal; font-style:normal; background-color:#F0F0F0";
            pdfDocument.TableOfContents.SetItemStyle(1, level1TextStyle);

            // Optionally set the page numbers style of level 1 items in table of contents
            string level1PageNumberStyle = "color:black; padding-right:3px; background-color:#F0F0F0; font-size:14px; font-weight:bold";
            pdfDocument.TableOfContents.SetPageNumberStyle(1, level1PageNumberStyle);

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Merge_Table_of_Contents.pdf";
            try
            {
                // Create the first HTML to PDF element
                HtmlToPdfElement firstHtml = new HtmlToPdfElement(0, 0, firstUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                firstHtml.ConversionDelay = 2;

                // Enable or disable the table of contents for the first HTML document
                firstHtml.TableOfContentsEnabled = includeFirstHtmlTocCheckBox.Checked;

                // Add the first HTML to PDF document
                AddElementResult firstAddResult = firstPdfPage.AddElement(firstHtml);

                PdfPage secondPdfPage = null;
                PointF secondHtmlLocation = Point.Empty;

                if (startNewPageCheckBox.Checked)
                {
                    // Create a PDF page where to add the second HTML
                    secondPdfPage = pdfDocument.AddPage();
                    secondHtmlLocation = PointF.Empty;
                }
                else
                {
                    // Add the second HTML on the PDF page where the first HTML ended
                    secondPdfPage = firstAddResult.EndPdfPage;
                    secondHtmlLocation = new PointF(firstAddResult.EndPageBounds.Left, firstAddResult.EndPageBounds.Bottom);
                }

                // Create the second HTML to PDF element
                HtmlToPdfElement secondHtml = new HtmlToPdfElement(secondHtmlLocation.X, secondHtmlLocation.Y, secondUrlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                secondHtml.ConversionDelay = 2;

                // Enable or disable the table of contents for the second HTML document
                secondHtml.TableOfContentsEnabled = includeSecondHtmlTocCheckBox.Checked;

                // Add the second HTML to PDF document
                secondPdfPage.AddElement(secondHtml);

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

        public Merge_Table_of_Contents_Demo()
        {
            InitializeComponent();
        }

        private void viewFirstHtmlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(firstUrlTextBox.Text);
        }

        private void viewSecondHtmlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(secondUrlTextBox.Text);
        }
    }
}
