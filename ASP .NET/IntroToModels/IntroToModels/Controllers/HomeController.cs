using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToModels.Models;

namespace IntroToModels.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Peter",
                EmailID = "Peter@gg"
            };
            return View(employee);
        }
    }
}