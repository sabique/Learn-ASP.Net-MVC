using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        #region Removed the property
        //public string UserName { get; set; } 
        #endregion
    }
}