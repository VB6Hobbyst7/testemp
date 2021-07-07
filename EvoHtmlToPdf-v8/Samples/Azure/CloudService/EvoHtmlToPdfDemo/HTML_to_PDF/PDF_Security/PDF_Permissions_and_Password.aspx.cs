using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.HTML_to_PDF.PDF_Security
{
    public partial class PDF_Permissions_and_Password : System.Web.UI.Page
    {
        protected void convertToPdfButton_Click(object sender, EventArgs e)
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

            // Convert the HTML page to a PDF document in a memory buffer
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(urlTextBox.Text);

            // Send the PDF as response to browser

            // Set response content type
            Response.AddHeader("Content-Type", "application/pdf");

            // Instruct the browser to open the PDF file as an attachment or inline
            Response.AddHeader("Content-Disposition", String.Format("attachment; filename=Set_Permissions_Password.pdf; size={0}", outPdfBuffer.Length.ToString()));

            // Write the PDF document buffer to HTTP response
            Response.BinaryWrite(outPdfBuffer);

            // End the HTTP response and stop the current page processing
            Response.End();
        }

        private bool PermissionsChanged(HtmlToPdfConverter htmlToPdfConverter)
        {
            return !htmlToPdfConverter.PdfSecurityOptions.CanPrint || !htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanCopyContent || !htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanEditContent || !htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                sampleCodeLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Code_Samples/CSharp/AspNet/HTML_to_PDF/PDF_Security/PDF_Permissions.html"));
                descriptionLiteral.Text = System.IO.File.ReadAllText(Server.MapPath("~/DemoAppFiles/Input/Descriptions/AspNet/HTML_to_PDF/PDF_Security/PDF_Permissions.html"));

                Master.CollapseAll();
                Master.ExpandNode("HTML_to_PDF");
                Master.ExpandNode("PDF_Security_Features");
                Master.SelectNode("PDF_Permissions_and_Password");
            }
        }

        protected void editContentEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editContentEnabledCheckBox.Checked)
                fillFormFieldsEnabledCheckBox.Checked = true;
        }

        protected void editAnnotationsEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editAnnotationsEnabledCheckBox.Checked)
                fillFormFieldsEnabledCheckBox.Checked = true;
        }

        protected void fillFormFieldsEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!fillFormFieldsEnabledCheckBox.Checked)
            {
                editContentEnabledCheckBox.Checked = false;
                editAnnotationsEnabledCheckBox.Checked = false;
            }
        }

        protected void demoMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (e.Item.Value)
            {
                case "Live_Demo":
                    demoMultiView.SetActiveView(liveDemoView);
                    break;
                case "Description":
                    demoMultiView.SetActiveView(descriptionView);
                    break;
                case "Sample_Code":
                    demoMultiView.SetActiveView(sampleCodeView);
                    break;
                default:
                    break;
            }
        }

        protected void rc4RadioButton_CheckedChanged(object sender, EventArgs e)
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

        protected void aesRadioButton_CheckedChanged(object sender, EventArgs e)
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