using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AEB_demo.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

     
            public ActionResult Recycling()
            {
            ViewBag.Title = "Recycling";
            return View();
            }

            public ActionResult AgroProcessing()
            {
            return View();
            }

            public ActionResult RegenerativeAgri()
            {
            return View();
            }

            public ActionResult RenewableEnergy() 
            { 
            return View();
            }

        public ActionResult AgriTechnologies() 
        {
            ViewBag.Title = "Agri Technologies";
            return View();
        }

        }
    }
