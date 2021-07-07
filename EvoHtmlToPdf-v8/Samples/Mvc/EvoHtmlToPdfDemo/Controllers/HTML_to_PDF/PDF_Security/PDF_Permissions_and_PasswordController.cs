using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers.HTML_to_PDF.PDF_Security
{
    public class PDF_Permissions_and_PasswordController : Controller
    {
        [HttpPost]
        public ActionResult ConvertHtmlToPdf(FormCollection collection)
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
            if (collection["EncryptionKey"] != "bit128RadioButton" || collection["EncryptionType"] != "rc4RadioButton")
            {
                // set the encryption algorithm
                htmlToPdfConverter.PdfSecurityOptions.EncryptionAlgorithm = collection["EncryptionType"] == "rc4RadioButton" ? EncryptionAlgorithm.RC4 : EncryptionAlgorithm.AES;

                // set the encryption key size
                if (collection["EncryptionKey"] == "bit40RadioButton")
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey40Bit;
                else if (collection["EncryptionKey"] == "bit128RadioButton")
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey128Bit;
                else if (collection["EncryptionKey"] == "bit256RadioButton")
                    htmlToPdfConverter.PdfSecurityOptions.KeySize = EncryptionKeySize.EncryptKey256Bit;
            }

            // Set user and owner passwords
            if (collection["userPasswordTextBox"].Length > 0)
                htmlToPdfConverter.PdfSecurityOptions.UserPassword = collection["userPasswordTextBox"];

            if (collection["ownerPasswordTextBox"].Length > 0)
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = collection["ownerPasswordTextBox"];

            // Set PDF document permissions
            htmlToPdfConverter.PdfSecurityOptions.CanPrint = collection["printEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution = collection["highResolutionPrintEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanCopyContent = collection["copyContentEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent = collection["copyAccessibilityContentEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanEditContent = collection["editContentEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations = collection["editAnnotationsEnabledCheckBox"] != null;
            htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields = collection["fillFormFieldsEnabledCheckBox"] != null;

            if ((PermissionsChanged(htmlToPdfConverter) || htmlToPdfConverter.PdfSecurityOptions.UserPassword.Length > 0) &&
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword.Length == 0)
            {
                // A user password is set but the owner password is not set or the permissions are not the default ones
                // Set a default owner password
                htmlToPdfConverter.PdfSecurityOptions.OwnerPassword = "owner";
            }

            // Convert the HTML page to a PDF document in a memory buffer
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(collection["urlTextBox"]);
            
            // Send the PDF file to browser
            FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "Set_Permissions_Password.pdf";

            return fileResult;
        }

        private bool PermissionsChanged(HtmlToPdfConverter htmlToPdfConverter)
        {
            return !htmlToPdfConverter.PdfSecurityOptions.CanPrint || !htmlToPdfConverter.PdfSecurityOptions.CanPrintHighResolution ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanCopyContent || !htmlToPdfConverter.PdfSecurityOptions.CanCopyAccessibilityContent ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanEditContent || !htmlToPdfConverter.PdfSecurityOptions.CanEditAnnotations ||
                    !htmlToPdfConverter.PdfSecurityOptions.CanFillFormFields;
        }
    }
}