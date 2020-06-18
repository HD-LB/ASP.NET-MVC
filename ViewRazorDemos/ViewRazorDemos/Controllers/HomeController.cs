using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewRazorDemos.ActionFilters;
using ViewRazorDemos.Models;

namespace ViewRazorDemos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            var model = new MyViewModels
            {
                Id = 1,
                Name = "Pesho"
            };

            return View(new[] { model, model, model });
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