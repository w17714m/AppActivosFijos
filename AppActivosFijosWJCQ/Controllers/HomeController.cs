using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppActivosFijosWJCQ.Controllers
{
    /// <summary>
    /// Página Inicial
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Página inicial
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

