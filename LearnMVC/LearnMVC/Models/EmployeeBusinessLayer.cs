using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnMVC.DataAccessLayer;

namespace LearnMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            #region Using the list to return the data
            //List<Employee> employees = new List<Employee>();

            //Employee emp = new Employee();
            //emp.FirstName = "Sabique";
            //emp.LastName = "Khan";
            //emp.Salary = 10000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "John";
            //emp.LastName = "Doe";
            //emp.Salary = 50000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.FirstName = "Jenny";
            //emp.LastName = "Doe";
            //emp.Salary = 60000;
            //employees.Add(emp);

            //return employees; 
            #endregion

            #region Returning the data from the database
            SalesERPDAL salesDAL = new SalesERPDAL();
            return salesDAL.Employees.ToList();
            #endregion
        }
    }
}