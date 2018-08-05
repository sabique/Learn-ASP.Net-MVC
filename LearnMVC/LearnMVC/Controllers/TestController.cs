using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Models;

namespace LearnMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Huraay! We have successfully run the ASP.Net MVC project.";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sabique";
            emp.LastName = "Khan";
            emp.Salary = 10000;

            //Commented the code
            //Uncomment the code if you need to pass the data to View using the ViewData
            //ViewData["Employee"] = emp;
            //return View("MyView");

            //Commented the code
            //Passing the data to View using the ViewBag
            //ViewBag.Employee = emp;
            //return View("MyView");

            return View("MyView", emp);
        }
    }
}