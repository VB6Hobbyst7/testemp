using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Repeat_HTML_Table_Header_FooterController : Controller
    {
        // GET: Repeat_HTML_Table_Header_Footer
        public ActionResult Index()
        {
            return View();
        }

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

            // Set if the HTML tables headers are repeated in PDF
            // You can also disable the header repeating if you add style="display: table-row-group" to thead tag in HTML
            htmlToPdfConverter.PdfDocumentOptions.TableHeaderRepeatEnabled = collection["repeatHtmlTableHeaderCheckBox"] != null;

            // Set if the HTML tables footers are repeated in PDF
            // You can also disable the footer repeating if you add style="display: table-row-group" to tfoot tag in HTML
            htmlToPdfConverter.PdfDocumentOptions.TableFooterRepeatEnabled = collection["repeatHtmlTableFooterCheckBox"] != null;

            byte[] outPdfBuffer = null;

            if (collection["HtmlPageSource"] == "convertHtmlRadioButton")
            {
                string htmlWithForm = collection["htmlStringTextBox"];
                string baseUrl = collection["baseUrlTextBox"];

                // Convert a HTML string with repetead header and footer to a PDF document in a memory buffer
                outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlWithForm, baseUrl);
            }
            else
            {
                string url = collection["urlTextBox"];

                // Convert the HTML page with repetead header and footer to a PDF document in a memory buffer
                outPdfBuffer = htmlToPdfConverter.ConvertUrl(url);
            }
            
            // Send the PDF file to browser
            FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "Repeat_HTML_Table_Header_Footer.pdf";

            return fileResult;
        }
    }
}