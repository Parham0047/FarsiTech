using FarsiTech.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FarsiTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GameArticles()
        {
            return View();
        }
        public IActionResult MyApps()
        {
            return View();
        }
        public IActionResult Survey()
        {
            return View();
        }
        [Authorize]
        public IActionResult SurveyRace()
        {
            return View();
        }
        public IActionResult TechArticles()
        {
            return View();
        }
        public IActionResult introduce()
        {
            return View();
        }
        public IActionResult tutorial()
        {
            return View();
        }
        public IActionResult IntroduceNewPart()
        {
            return View();
        }

        public IActionResult News()
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
