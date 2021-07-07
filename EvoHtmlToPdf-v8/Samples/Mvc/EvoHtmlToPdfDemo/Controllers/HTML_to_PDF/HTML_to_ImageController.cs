using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class HTML_to_ImageController : Controller
    {
        public ActionResult Convert_HTML_to_Image()
        {
            return View();
        }

        public ActionResult Convert_HTML_to_SVG()
        {
            return View();
        }
    }
}