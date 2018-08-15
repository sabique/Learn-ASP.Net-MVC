using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnMVC.Models;
using LearnMVC.ViewModels;

namespace LearnMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string GetString()
        {
            return "Huraay! We have successfully run the ASP.Net MVC project.";
        }

        public ActionResult Index()
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
            //removed the property UserName
            //employeeListViewModel.UserName = "Admin";

            //Updated the View name to Index from MyView
            //return View("MyView", employeeListViewModel); 
            return View("Index", employeeListViewModel);
            #endregion
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        public ActionResult SaveEmployee(Employee e, string btnSubmit)
        {
            switch (btnSubmit)
            {
                case "Save Employee":
                    #region Code to display the submitted values
                    //return Content(e.FirstName + " | " + e.LastName + " | " + e.Salary); 
                    #endregion

                    EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                    empBal.SaveEmployee(e);
                    return RedirectToAction("Index");
                case "Cancel":
                    return RedirectToAction("Index");
            }

            return new EmptyResult();
        }
    }
}