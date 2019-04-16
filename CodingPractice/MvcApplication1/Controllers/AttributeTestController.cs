using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class AttributeTestController : Controller
    {
        private string ExternalView = "External";
        private string InternalView = "Internal";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sel)
        {
            string rtValue = "";

            switch (sel)
            {
                case "I":
                    Internal IN = new Internal();
                    ViewBag.Description = IN.Description;
                    ViewBag.Author = IN.Article.Author;
                    rtValue = InternalView;
                    break;
                case "E":
                    External Ex = new External();
                    ViewBag.Description = Ex.Description;
                    ViewBag.Author = Ex.Article.Author;
                    rtValue = ExternalView;
                    break;
            }

            return View(rtValue);
        }

    }
}
