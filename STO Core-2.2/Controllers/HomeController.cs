using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STO_Core_2._2.Models;
using Wangkanai.Detection;

namespace STO_Core_2._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDetection _detection;
        public HomeController(IDetection detection)
        {
            _detection = detection;
        }
        public IActionResult Index()
        {
            string browser_info = _detection.Browser.Type.ToString() +" "+ _detection.Browser.Version;
            ViewData["a"] = browser_info;
            return View(_detection);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
