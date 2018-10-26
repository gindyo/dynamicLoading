using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterfaceLibrary;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestClass _klass;

        public HomeController(ITestClass klass)
        {
            _klass = klass;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Hi = this._klass.SayHi();
            return View();
        }
    }
}
