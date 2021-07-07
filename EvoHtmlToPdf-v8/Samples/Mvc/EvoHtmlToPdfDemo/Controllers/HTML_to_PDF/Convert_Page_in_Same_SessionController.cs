using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;
using System.Text;
using System.Web.UI;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Convert_Page_in_Same_SessionController : Controller
    {
        // GET: Convert_Page_in_Same_Session
        public ActionResult Index()
        {
            ViewData.Add("firstName", "John");
            ViewData.Add("lastName", "Smith");
            ViewData.Add("gender", "maleRadioButton");
            ViewData.Add("haveCar", "true");
            ViewData.Add("carType", "Volvo");
            ViewData.Add("comments", "My comments\r\nLine 1\r\nLine 2");

            return View();
        }

        public ActionResult Display_Session_Variables()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConvertPageInSameSessionToPdf(FormCollection collection)
        {
            object model = null;
            ViewDataDictionary viewData = new ViewDataDictionary(model);

            // transmit the posted data to view
            viewData.Add("firstName", collection["firstNameTextBox"]);
            viewData.Add("lastName", collection["lastNameTextBox"]);
            viewData.Add("gender", collection["gender"]);
            viewData.Add("haveCar", collection["haveCarCheckBox"]);
            viewData.Add("carType", collection["carTypeDropDownList"]);
            viewData.Add("comments", collection["commentsTextBox"]);

            // The string writer where to render the HTML code of the view
            StringWriter stringWriter = new StringWriter();

            // Render the Index view in a HTML string
            ViewEngineResult viewResult = ViewEngines.Engines.FindView(ControllerContext, "Display_Session_Variables", null);
            ViewContext viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    viewData,
                    new TempDataDictionary(),
                    stringWriter
                    );
            viewResult.View.Render(viewContext, stringWriter);

            // Get the view HTML string
            string htmlToConvert = stringWriter.ToString();

            // Get the base URL
            String currentPageUrl = this.ControllerContext.HttpContext.Request.Url.AbsoluteUri;
            String baseUrl = currentPageUrl.Substring(0, currentPageUrl.Length - "Convert_Page_in_Same_Session/ConvertPageInSameSessionToPdf".Length);

            // Create a HTML to PDF converter object with default settings
            HtmlToPdfConverter htmlToPdfConverter = new HtmlToPdfConverter();

            // Set license key received after purchase to use the converter in licensed mode
            // Leave it not set to use the converter in demo mode
            htmlToPdfConverter.LicenseKey = "4W9+bn19bn5ue2B+bn1/YH98YHd3d3c=";

            // Set an adddional delay in seconds to wait for JavaScript or AJAX calls after page load completed
            // Set this property to 0 if you don't need to wait for such asynchcronous operations to finish
            htmlToPdfConverter.ConversionDelay = 2;

            // Convert the HTML string to a PDF document in a memory buffer
            byte[] outPdfBuffer = htmlToPdfConverter.ConvertHtml(htmlToConvert, baseUrl);

            // Send the PDF file to browser
            FileResult fileResult = new FileContentResult(outPdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "Convert_Page_in_Same_Session.pdf";

            return fileResult;
        }
    }
}