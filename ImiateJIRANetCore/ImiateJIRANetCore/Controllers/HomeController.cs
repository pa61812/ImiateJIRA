using ImiateJIRANetCore.Interface;
using ImiateJIRANetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IJiraServices _jira;

        public HomeController(ILogger<HomeController> logger, IJiraServices jira)
        {
            _logger = logger;
            _jira = jira;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var result = _jira.GetJiraOrders();
            return View(result);
        }

        public IActionResult PartialJIRA()
        {
            return PartialView();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ActionResult EditJira(int key)
        {
            var result = _jira.GetJiraOrders(key.ToString());
            return View(result);
        }
    }
}
