using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationwithJquery.Models;

namespace WebApplicationwithJquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllStudents()
        {
            Student std = new Student()
            {
                Id = 1,
                Name = "XYZ",
                Address = "test"

            };

            var json = JsonConvert.SerializeObject(std);
            return Json(json,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddStudents(Student stud)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}