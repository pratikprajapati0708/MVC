using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAXbeginform.Models;

namespace AJAXbeginform.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Index(Student model)
        {
            return Json("true",JsonRequestBehavior.AllowGet);
        }

    }
}