using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Drawing;

// Use EVO PDF Namespace
using EvoPdf;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Headers_and_FootersController : Controller
    {
        public ActionResult HTML_in_Header_Footer()
        {
            return View();
        }

        public ActionResult Page_Numbers_in_HTML()
        {
            return View();
        }

        public ActionResult Header_Footer_Change()
        {
            return View();
        }

        public ActionResult Header_Footer_In_External_PDF()
        {
            return View();
        }

        public ActionResult Header_Footer_on_Merged_HTML()
        {
            return View();
        }

        public ActionResult Header_Footer_Auto_Resize()
        {
            return View();
        }
    }
}