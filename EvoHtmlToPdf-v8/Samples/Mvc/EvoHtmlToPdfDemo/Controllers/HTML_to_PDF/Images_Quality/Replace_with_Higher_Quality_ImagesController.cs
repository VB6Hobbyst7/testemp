using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers.HTML_to_PDF.Images_Quality
{
    public class Replace_with_Higher_Quality_ImagesController : Controller
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

            // Select all images from HTML page
            htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = new string[] { "img" };

            // Exclude the original images from rendering becuase they will be replaced by an image from local file system
            htmlToPdfConverter.HiddenHtmlElementsSelectors = new string[] { "img" };

            Document pdfDocument = null;
            try
            {
                // Convert a HTML string with images to replace to a PDF document object
                pdfDocument = htmlToPdfConverter.ConvertUrlToPdfDocumentObject(collection["urlTextBox"]);

                // Replace the images selected in HTML using special attributes with images from local file system
                foreach (HtmlElementMapping imageElementInfo in htmlToPdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult)
                {
                    PdfPage imagePdfPage = imageElementInfo.PdfRectangles[0].PdfPage;
                    RectangleF imageRectangle = imageElementInfo.PdfRectangles[0].Rectangle;

                    ImageElement newImageElement = new ImageElement(imageRectangle.X, imageRectangle.Y, imageRectangle.Width, imageRectangle.Height,
                                    Server.MapPath("~/DemoAppFiles/Input/Images/box.jpg"));
                    newImageElement.EnlargeEnabled = true;
                    imagePdfPage.AddElement(newImageElement);
                }

                // Save the PDF document in a memory buffer
                byte[] outPdfBuffer = pdfDocument.Save();
                
                // Send the PDF file to browser
                FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
                fileResult.FileDownloadName = "Replace_with_Higher_Quality_Images.pdf";

                return fileResult;
            }
            finally
            {
                // Close the PDF document
                if (pdfDocument != null)
                    pdfDocument.Close();
            }            
        }
    }
}