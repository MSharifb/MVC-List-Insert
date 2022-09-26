using EmployeeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {  
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel model)
        {
            EmployeeViewModel model2 = new EmployeeViewModel();
            model2.Empinfo.Add(model);
            return View(model2);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}