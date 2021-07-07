using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvoHtmlToPdfDemo.Controllers
{
    public class Table_of_ContentsController : Controller
    {
        public ActionResult Auto_Create_Table_of_Contents()
        {
            return View();
        }

        public ActionResult Define_in_HTML_Table_of_Contents_Items()
        {
            return View();
        }

        public ActionResult Merge_Table_of_Contents()
        {
            return View();
        }

        public ActionResult Insert_PDF_Pages_Before_Table_of_Contents()
        {
            return View();
        }
    }
}