using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validations_IN_MVC_LooselyBindling.Models;

namespace Validations_IN_MVC_LooselyBindling.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Validations----> 1. Client Side 2. Server Side
        //Validation Attributes------
        //Required, MinLength,Email etc.
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Employee emp)
        {
            if(ModelState.IsValid)  // Using ModelState Server side validation
            {
                return View();
            }
            return View("Index");
        }
    }
}