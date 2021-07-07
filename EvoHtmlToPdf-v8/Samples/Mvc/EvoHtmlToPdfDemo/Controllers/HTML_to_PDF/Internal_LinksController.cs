using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Internal_LinksController : Controller
    {
        public ActionResult Convert_Internal_Links_to_PDF()
        {
            return View();
        }

        public ActionResult Define_Custom_Internal_Links()
        {
            return View();
        }
    }
}