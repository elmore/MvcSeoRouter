using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebsite.Models;

namespace DemoWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string seo)
        {
            var model = new HomeModel();

            model.Seo = seo;

            return View(model);
        }

    }
}
