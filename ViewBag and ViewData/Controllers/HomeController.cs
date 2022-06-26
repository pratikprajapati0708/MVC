using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_and_ViewData.Models;

namespace ViewBag_and_ViewData.Controllers
{
    public class HomeController : Controller
    {

        // View Bag and View Data is used to pass Data From Controller to View only.It is dynamic type and
        // We can assign any name to the property .
      
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomProperty = "Pratik";
            ViewBag.MyList = new List<string>() { "john", "mark", "kim", "rock" };
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){Email = "a@gmail.com", Id=1, Name="John" },
                new Employee(){Email = "b@gmail.com", Id=2, Name="John1" },
                new Employee(){Email = "c@gmail.com", Id=3, Name="John2" },
                new Employee(){Email = "d@gmail.com", Id=4, Name="John3" },
               

            };
            ViewBag.MyEmpList = empList;
            return View();
        }


        //ViewData works as Dictionary

        public ActionResult Demo()
        {
            ViewData["My Key"] = "This is value of my Key";
            ViewData["MyList"] = new List<string>() { "john", "mark", "kim", "rock" };
            return View();
        }
    }
}