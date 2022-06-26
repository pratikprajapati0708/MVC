using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        //TO save data for next HTTP call we use Keep() method.
        //To save data for all TempData we use Keep() method.
        //To save data for a particular key we use Keep("key").      TempData.keep("key")
        //TempData is used to pass data from controller to controller. It is also a dictionary pair
        
        
        //Peek- Method
        //Peek is used to get the data and save for the next call
        //Peek() = Get data from TempData() + Keep()

        // GET: Home
        public ActionResult Index()
        {
            TempData["myData"] = "Data from Index";
            return View();
        }
        public ActionResult Index2()
        {
            //ViewBag.MyData = TempData["myData"];
            //TempData.Keep("myData");
            //OR                  // Session.Abandon() --> Abandon the session and tempdata uses Session
            ViewBag.MyData = TempData.Peek("myData");
            return View();
        } 
        public ActionResult Index3()
        {
            ViewBag.MyData = TempData["myData"];
            return View();
        }
    }
}