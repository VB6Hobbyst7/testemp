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
    public partial class Merge_PDF_Demo : UserControl
    {
        private void mergePdfButton_Click(object sender, EventArgs e)
        {
            // Create the merge result PDF document
            Document mergeResultPdfDocument = new Document();

            // Automatically close the merged documents when the document resulted after merge is closed
            mergeResultPdfDocument.AutoCloseAppendedDocs = true;

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            mergeResultPdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            Cursor = Cursors.WaitCursor;
            string outPdfFile = @"DemoAppFiles\Output\PDF_Editor\Merge_PDF.pdf";
            try
            {                
                // The documents to merge must remain opened until the PDF document resulted after merge is saved
                // The merged documents can be automatically closed when the document resulted after merge is closed
                // if the AutoCloseAppendedDocs property of the PDF document resulted after merge is set on true like
                // in this demo applcation

                // Load the first PDF document to merge
                Document firstPdfDocumentToMerge = new Document(firstPdfFilePathTextBox.Text);
                // Merge the first PDF document
                mergeResultPdfDocument.AppendDocument(firstPdfDocumentToMerge);

                // Load the second PDF document to merge
                Document secondPdfDocumentToMerge = new Document(secondPdfFilePathTextBox.Text);
                // Merge the second PDF document
                mergeResultPdfDocument.AppendDocument(secondPdfDocumentToMerge);

                // Save the merge result PDF document in a memory buffer
                byte[] outPdfBuffer = mergeResultPdfDocument.Save();

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
                // Close the PDF document resulted after merge
                // When the AutoCloseAppendedDocs property is true the merged PDF documents will also be closed
                mergeResultPdfDocument.Close();

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

        private void Merge_PDF_Demo_Load(object sender, EventArgs e)
        {
            firstPdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, @"DemoAppFiles\Input\PDF_Files\Merge_Before_Conversion.pdf");
            secondPdfFilePathTextBox.Text = System.IO.Path.Combine(Application.StartupPath, @"DemoAppFiles\Input\PDF_Files\Merge_After_Conversion.pdf");
        }

        private void selectFirstPdfFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                firstPdfFilePathTextBox.Text = fd.FileName;
            }
        }

        private void selectSecondPdfFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                secondPdfFilePathTextBox.Text = fd.FileName;
            }
        }

        public Merge_PDF_Demo()
        {
            InitializeComponent();
        }
    }
}
