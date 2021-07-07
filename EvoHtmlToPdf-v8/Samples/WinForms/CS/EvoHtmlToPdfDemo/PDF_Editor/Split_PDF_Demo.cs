using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Editor
{
    public partial class Split_PDF_Demo : UserControl
    {
        string splitResultPdfFile1 = @"DemoAppFiles\Output\PDF_Editor\Split_PDF_1.pdf";
        string splitResultPdfFile2 = @"DemoAppFiles\Output\PDF_Editor\Split_PDF_2.pdf";

        private void splitPdfButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            splitResultPanel.Visible = false;

            Document pdfDocumentToSplit = null;
            Document splitResultDocument1 = null;
            Document splitResultDocument2 = null;
            try
            {
                // Load the PDF document to split
                // The document must remain opened until the PDF documents resulted after split are saved
                pdfDocumentToSplit = new Document(pdfFilePathTextBox.Text);

                // Get the page count of the document to split
                int pageCount = pdfDocumentToSplit.Pages.Count;

                // Check if the document has the minimum required number of page
                if (pageCount < 2)
                {
                    MessageBox.Show("The document to split must have at least 2 pages");
                    return;
                }

                // Create the first PDF document resulted after split
                splitResultDocument1 = new Document();
                // Set license key received after purchase
                splitResultDocument1.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";
                // Copy pages from loaded document into split result document
                splitResultDocument1.AppendDocument(pdfDocumentToSplit, 0, pageCount / 2);
                // Save the first PDF document document resulted after split in a memory buffer
                byte[] outPdfBuffer1 = splitResultDocument1.Save();
                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(splitResultPdfFile1, outPdfBuffer1);

                // Create the second PDF document resulted after split  
                splitResultDocument2 = new Document();
                // Set license key received after purchase
                splitResultDocument2.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";
                // Copy pages from loaded document into split result document
                splitResultDocument2.AppendDocument(pdfDocumentToSplit, pageCount / 2, pageCount - pageCount / 2);
                // Save the second PDF document document resulted after split in a memory buffer
                byte[] outPdfBuffer2 = splitResultDocument2.Save();
                // Write the memory buffer in a PDF file
                System.IO.File.WriteAllBytes(splitResultPdfFile2, outPdfBuffer2);

                splitResultPanel.Visible = true;
            }
            catch (Exception ex)
            {
                // The PDF split failed
                MessageBox.Show(String.Format("Split PDF Error. {0}", ex.Message));
                return;
            }
            finally
            {
                // Close all the PDF documents after the PDF documents resulted after split were already saved

                // Close the first split result document
                if (splitResultDocument1 != null)
                    splitResultDocument1.Close();

                // Close the second split result document
                if (splitResultDocument2 != null)
                    splitResultDocument2.Close();

                // Close the document to split
                if (pdfDocumentToSplit != null)
                    pdfDocumentToSplit.Close();

                Cursor = Cursors.Arrow;
            }
        }

        private void Split_PDF_Demo_Load(object sender, EventArgs e)
        {
            pdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, @"DemoAppFiles\Input\PDF_Files\PDF_Document.pdf");
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pdfFilePathTextBox.Text = fd.FileName;
            }
        }

        public Split_PDF_Demo()
        {
            InitializeComponent();
        }

        private void openFirstLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(splitResultPdfFile1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", splitResultPdfFile1, ex.Message));
            }
        }

        private void openSecondLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(splitResultPdfFile2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open created PDF file '{0}'. {1}", splitResultPdfFile2, ex.Message));
            }
        }

        private void openInitialLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(pdfFilePathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Cannot open initial PDF file '{0}'. {1}", pdfFilePathTextBox.Text, ex.Message));
            }
        }
    }
}
