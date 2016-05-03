using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }
    }
}
