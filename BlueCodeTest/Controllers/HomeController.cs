using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueCodeTest.Controllers
{
    public class HomeController : Controller
    {
        readonly IPersonManager _personManager;
        public HomeController(IPersonManager personManager)
        {
            _personManager = personManager;
        }

        public ActionResult Index()
        {
            var data = _personManager.GetPersonsAll();
            return View(data);
        }

    }
}