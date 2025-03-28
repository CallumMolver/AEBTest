using AEB_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AEB_demo.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Calculate(CalculatorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return View("Results", model);
        }
    }
}