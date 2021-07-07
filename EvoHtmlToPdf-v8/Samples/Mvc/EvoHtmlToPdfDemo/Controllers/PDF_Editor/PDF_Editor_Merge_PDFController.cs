using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers.PDF_Editor
{
    public class PDF_Editor_Merge_PDFController : Controller
    {
        // GET: PDF_Editor_Merge_PDF
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MergePdf(FormCollection collection)
        {
            // Create the merge result PDF document
            Document mergeResultPdfDocument = new Document();

            // Automatically close the merged documents when the document resulted after merge is closed
            mergeResultPdfDocument.AutoCloseAppendedDocs = true;

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            mergeResultPdfDocument.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            try
            {
                // The documents to merge must remain opened until the PDF document resulted after merge is saved
                // The merged documents can be automatically closed when the document resulted after merge is closed
                // if the AutoCloseAppendedDocs property of the PDF document resulted after merge is set on true like
                // in this demo applcation

                // Load the first PDF document to merge
                string firstPdfFilePath = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_Before_Conversion.pdf");
                Document firstPdfDocumentToMerge = new Document(firstPdfFilePath);
                // Merge the first PDF document
                mergeResultPdfDocument.AppendDocument(firstPdfDocumentToMerge);

                // Load the second PDF document to merge
                string secondPdfFilePath = Server.MapPath("~/DemoAppFiles/Input/PDF_Files/Merge_After_Conversion.pdf");
                Document secondPdfDocumentToMerge = new Document(secondPdfFilePath);
                // Merge the second PDF document
                mergeResultPdfDocument.AppendDocument(secondPdfDocumentToMerge);

                // Save the merge result PDF document in a memory buffer
                byte[] outPdfBuffer = mergeResultPdfDocument.Save();
                
                // Send the PDF file to browser
                FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
                fileResult.FileDownloadName = "Merge_PDF.pdf";

                return fileResult;
            }
            finally
            {
                // Close the PDF document resulted after merge
                // When the AutoCloseAppendedDocs property is true the merged PDF documents will also be closed
                mergeResultPdfDocument.Close();
            }
        }
    }
}