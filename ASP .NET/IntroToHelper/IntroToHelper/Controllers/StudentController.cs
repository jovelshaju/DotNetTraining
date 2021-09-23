using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToHelper.Models;

namespace IntroToHelper.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index2()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "John",
                Age = 10
            };

            return View(student);
        }

        
    }
}