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
            #region No need to intialize object for Employee when using the list
            //Employee emp = new Employee();
            //emp.FirstName = "Sabique";
            //emp.LastName = "Khan";
            //emp.Salary = 10000; 
            #endregion

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
            //EmployeeViewModel vmEmp = new EmployeeViewModel();
            //vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            //vmEmp.Salary = emp.Salary.ToString("C");

            //if (emp.Salary > 15000)
            //    vmEmp.SalaryColor = "yellow";
            //else
            //    vmEmp.SalaryColor = "green";

            //vmEmp.UserName = "Admin";

            //return View("MyView", vmEmp);
            #endregion


            #region Code to pass the multiple data to View using the ViewModel
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();

                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");

                if (emp.Salary > 15000)
                    empViewModel.SalaryColor = "yellow";
                else
                    empViewModel.SalaryColor = "green";

                empViewModels.Add(empViewModel);
            }

            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";

            return View("MyView", employeeListViewModel); 
            #endregion
        }
    }
}