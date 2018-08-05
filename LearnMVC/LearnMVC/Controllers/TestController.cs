using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Models;
using LearnMVC.ViewModels;

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

            #region Code to pass the data to View using the ViewData
            //ViewData["Employee"] = emp;
            //return View("MyView"); 
            #endregion

            #region Code to pass the data to View using the ViewBag
            //ViewBag.Employee = emp;
            //return View("MyView");
            #endregion

            #region Code to pass the data to View using the Model
            //return View("MyView", emp); 
            #endregion

            #region Code to pass the data to View using the ViewModel
            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");

            if (emp.Salary > 15000)
                vmEmp.SalaryColor = "yellow";
            else
                vmEmp.SalaryColor = "green";

            vmEmp.UserName = "Admin";

            return View("MyView", vmEmp);
            #endregion
        }
    }
}