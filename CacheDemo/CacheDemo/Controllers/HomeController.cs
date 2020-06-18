using CacheDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CacheDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]       
        public ActionResult Index()
        {
       
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

        [ChildActionOnly]
        [OutputCache(Duration = 100)]
        public ActionResult CachedDate()
        {
            ViewBag.Date = DateTime.UtcNow;

            return this.PartialView("_CachedDatePartial");
        }
    }
}