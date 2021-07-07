using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers.PDF_Creator
{
    public class PDF_Creator_PDF_SecurityController : Controller
    {
        public ActionResult PDF_Creator_PDF_Permissions_and_Password()
        {
            return View();
        }

        public ActionResult PDF_Creator_Digital_Signatures()
        {
            return View();
        }
    }
}