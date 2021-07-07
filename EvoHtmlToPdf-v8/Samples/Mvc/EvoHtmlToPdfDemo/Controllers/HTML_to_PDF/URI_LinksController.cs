using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class URI_LinksController : Controller
    {
        public ActionResult Convert_URI_Links_to_PDF()
        {
            return View();
        }

        public ActionResult Define_Custom_URI_Links()
        {
            return View();
        }
    }
}