using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData_mvc.Models;

namespace ViewData_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data !!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = { "Apple", "Banana", "Grapes", "Orange" };
            ViewData["FruitsArray"] = Fruits;

            ViewData["SportsList"] = new List<string>()
            {
                "Cricket",
                "Hockey",
                "Football",
                "Volley Ball"
            };

            Employee Ali = new Employee();
            Ali.EmpID = 11;
            Ali.EmpName = "Ali Khan";
            Ali.EmpDesignation = "Manager";

            ViewData["Employee"] = Ali;

            return View();
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