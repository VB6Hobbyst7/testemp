using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class PDF_SecurityController : Controller
    {
        public ActionResult PDF_Permissions_and_Password()
        {
            return View();
        }

        public ActionResult Digital_Signatures()
        {
            return View();
        }
    }
}