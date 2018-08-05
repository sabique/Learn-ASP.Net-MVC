using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "Huraay! We have successfully run the ASP.Net MVC project.";
        }
    }
}