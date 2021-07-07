using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Page_BreaksController : Controller
    {
        public ActionResult Insert_Page_Breaks_Before_After_Using_CSS()
        {
            return View();
        }

        public ActionResult Avoid_Page_Breaks_Inside_HTML_Elements_Using_CSS()
        {
            return View();
        }

        public ActionResult Insert_Page_Breaks_Before_After_Using_API()
        {
            return View();
        }

        public ActionResult Avoid_Page_Breaks_Inside_HTML_Elements_Using_API()
        {
            return View();
        }

        public ActionResult Avoid_Page_Breaks_Inside_Images_Using_API()
        {
            return View();
        }
    }
}