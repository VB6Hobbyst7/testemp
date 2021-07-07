using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
{
    public partial class PDF_Permissions_and_Password_Demo : UserControl
    {
        public PDF_Permissions_and_Password_Demo()
        {
            InitializeComponent();
        }

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

            // Set the encryption algorithm and the encryption key size if they are not the default ones
            if (!bit128RadioButton.Checked || !rc4RadioButton.Checked)
            {
                // set the encryption algorithm
                htmlToPdfConverter.PdfSecurityOptions.EncryptionAlgorithm = rc4RadioButton.Checked ? EncryptionAlgorithm.RC4 : EncryptionAlgorithm.AES;
                
                // set the encryption key size
                if (bit40RadioButton.Checked)
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey40Bit;
                else if (bit128RadioButton.Checked)
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey128Bit;
                else if (bit256RadioButton.Checked)
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey256Bit;
            }
            
            // Set user and owner passwords
            if (userPasswordTextBox.Text.Length > 0)
                htmlToPdfConverter.PdfSecurityOptions.UserPassword = userPasswordTextBox.Text;

            if (ownerPasswordTextBox.Text.Length > 0)
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = ownerPasswordTextBox.Text;            

            // Set PDF document permissions
            htmlToPdfConverter.PdfSecurityOptions.CanPrint = printEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution = highResolutionPrintEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanCopyContent = copyContentEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent = copyAccessibilityContentEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanEditContent = editContentEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations = editAnnotationsEnabledCheckBox.Checked;
            htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields = fillFormFieldsEnabledCheckBox.Checked;

            if ((PermissionsChanged(htmlToPdfConverter) || htmlToPdfConverter.PdfSecurityOptions.UserPassword.Length > 0) &&
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword.Length == 0)
            {
                // A user password is set but the owner password is not set or the permissions are not the default ones
                // Set a default owner password
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = "owner";
            }

            Cursor = Cursors.WaitCursor;

            // Convert HTML to PDF using the settings above
            string outPdfFile = @"DemoAppFiles\Output\HTML_to_PDF\Set_Permissions_Password.pdf";
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

        private bool PermissionsChanged(HtmlToPdfConverter htmlToPdfConverter)
        {
            return  !htmlToPdfConverter.PdfSecurityOptions.CanPrint || !htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanCopyContent || !htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanEditContent || !htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields;
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
