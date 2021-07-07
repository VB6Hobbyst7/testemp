using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.PDF_Creator.PDF_Security
{
    public partial class PDF_Permissions_and_Password_Demo : UserControl
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

            // Set the encryption algorithm and the encryption key size if they are not the default ones
            if (!bit128RadioButton.Checked || !rc4RadioButton.Checked)
            {
                // set the encryption algorithm
                pdfDocument.Security.EncryptionAlgorithm = rc4RadioButton.Checked ? EncryptionAlgorithm.RC4 : EncryptionAlgorithm.AES;

                // set the encryption key size
                if (bit40RadioButton.Checked)
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey40Bit;
                else if (bit128RadioButton.Checked)
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey128Bit;
                else if (bit256RadioButton.Checked)
                    pdfDocument.Security.KeySize = EncryptionKeySize.EncryptKey256Bit;
            }
            
            // Set user and owner passwords
            if (userPasswordTextBox.Text.Length > 0)
                pdfDocument.Security.UserPassword = userPasswordTextBox.Text;

            if (ownerPasswordTextBox.Text.Length > 0)
                pdfDocument.Security.OwnerPassword = ownerPasswordTextBox.Text;
            
            // Set PDF document permissions
            pdfDocument.Security.CanPrint = printEnabledCheckBox.Checked;
            pdfDocument.Security.CanPrintHighResolution = highResolutionPrintEnabledCheckBox.Checked;
            pdfDocument.Security.CanCopyContent = copyContentEnabledCheckBox.Checked;
            pdfDocument.Security.CanCopyAccessibilityContent = copyAccessibilityContentEnabledCheckBox.Checked;
            pdfDocument.Security.CanEditContent = editContentEnabledCheckBox.Checked;
            pdfDocument.Security.CanEditAnnotations = editAnnotationsEnabledCheckBox.Checked;
            pdfDocument.Security.CanFillFormFields = fillFormFieldsEnabledCheckBox.Checked;

            if ((PermissionsChanged(pdfDocument) || pdfDocument.Security.UserPassword.Length > 0) &&
                pdfDocument.Security.OwnerPassword.Length == 0)
            {
                // A user password is set but the owner password is not set or the permissions are not the default ones
                // Set a default owner password
                pdfDocument.Security.OwnerPassword = "owner";
            }

            Cursor = Cursors.WaitCursor;

            string outPdfFile = @"DemoAppFiles\Output\PDF_Creator\Set_Permissions_Password.pdf";
            try
            {
                // Create a HTML to PDF element to add to document
                HtmlToPdfElement htmlToPdfElement = new HtmlToPdfElement(urlTextBox.Text);

                // Optionally set a delay before conversion to allow asynchonous scripts to finish
                htmlToPdfElement.ConversionDelay = 2;

                // Add the HTML to PDF element to document
                pdfPage.AddElement(htmlToPdfElement);

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

        private bool PermissionsChanged(Document pdfDocument)
        {
            return !pdfDocument.Security.CanPrint || !pdfDocument.Security.CanPrintHighResolution ||
                    !pdfDocument.Security.CanCopyContent || !pdfDocument.Security.CanCopyAccessibilityContent ||
                    !pdfDocument.Security.CanEditContent || !pdfDocument.Security.CanEditAnnotations ||
                    !pdfDocument.Security.CanFillFormFields;
        }

        private void editContentEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editContentEnabledCheckBox.Checked)
                fillFormFieldsEnabledCheckBox.Checked = true;
        }

        private void editAnnotationsEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editAnnotationsEnabledCheckBox.Checked)
                fillFormFieldsEnabledCheckBox.Checked = true;
        }

        private void fillFormFieldsEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!fillFormFieldsEnabledCheckBox.Checked)
            {
                editContentEnabledCheckBox.Checked = false;
                editAnnotationsEnabledCheckBox.Checked = false;
            }
        }

        public PDF_Permissions_and_Password_Demo()
        {
            InitializeComponent();
        }

        private void rc4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rc4RadioButton.Checked)
            {
                // RC4 does not support the 256-bit encryption key size
                bit256RadioButton.Enabled = false;
                bit40RadioButton.Enabled = true;
            }
            else
            {
                // AES does not support the 40-bit encryption key size
                bit256RadioButton.Enabled = true;
                bit40RadioButton.Enabled = false;
            }

            bit128RadioButton.Checked = true;
            bit40RadioButton.Checked = false;
            bit256RadioButton.Checked = false;
        }
    }
}
