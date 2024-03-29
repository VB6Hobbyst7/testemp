﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers.HTML_to_PDF.Bookmarks
{
    public class Select_in_HTML_Elements_to_BookmarkController : Controller
    {
        [HttpPost]
        [ValidateInput(false)]
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

            // Display the bookmarks panel in PDF viewer when the generated PDF is opened
            htmlToPdfConverter.PdfViewerPreferences.PageMode = ViewerPageMode.UseOutlines;

            byte[] outPdfBuffer = null;

            if (collection["HtmlPageSource"] == "convertHtmlRadioButton")
            {
                string htmlWithBookmarkAttributes = collection["htmlStringTextBox"];
                string baseUrl = collection["baseUrlTextBox"];

                // Convert a HTML string with bookmark attributes to a PDF document in a memory buffer
                outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithBookmarkAttributes, baseUrl);
            }
            else
            {
                string url = collection["urlTextBox"];

                // Convert a HTML page with bookmark attributes to a PDF document in a memory buffer
                outPdfBuffer = htmlToPdfConverter.ConvertUrl(url);
            }
            
            // Send the PDF file to browser
            FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "Select_in_HTML_Elements_to_Bookmark.pdf";

            return fileResult;
        }
    }
}