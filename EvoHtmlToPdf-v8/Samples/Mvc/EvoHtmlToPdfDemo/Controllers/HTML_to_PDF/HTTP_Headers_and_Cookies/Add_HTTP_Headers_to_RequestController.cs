using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers.HTML_to_PDF.HTTP_Headers_and_Cookies
{
    public class Add_HTTP_Headers_to_RequestController : Controller
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

            // Add custom HTTP headers

            if (collection["header1NameTextBox"].Length > 0 && collection["header1ValueTextBox"].Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(collection["header1NameTextBox"], collection["header1ValueTextBox"]);

            if (collection["header2NameTextBox"].Length > 0 && collection["header2ValueTextBox"].Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(collection["header2NameTextBox"], collection["header2ValueTextBox"]);

            if (collection["header3NameTextBox"].Length > 0 && collection["header3ValueTextBox"].Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(collection["header3NameTextBox"], collection["header3ValueTextBox"]);

            if (collection["header4NameTextBox"].Length > 0 && collection["header4ValueTextBox"].Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(collection["header4NameTextBox"], collection["header4ValueTextBox"]);

            if (collection["header5NameTextBox"].Length > 0 && collection["header5ValueTextBox"].Length > 0)
                htmlToPdfConverter.HttpRequestHeaders.Add(collection["header5NameTextBox"], collection["header5ValueTextBox"]);

            // Convert the HTML page to a PDF document in a memory buffer
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertUrl(collection["urlTextBox"]);

            // Send the PDF file to browser
            FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "HTTP_Headers.pdf";

            return fileResult;
        }
    }
}