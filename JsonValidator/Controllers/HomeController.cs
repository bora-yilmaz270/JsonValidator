using JsonValidator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonValidator.Controllers
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

        [HttpPost]
        public ActionResult Index(JSONValidationViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.JSONString))
            {
                ModelState.AddModelError("JSONString", "Please enter the json string");
                return View(model);
            }
            try
            {
                JObject.Parse(model.JSONString);
                model.IsValid = true;

            }

            catch (JsonReaderException ex)
            {
                model.IsValid = false;
                model.ErrorMessage = ex.Message;
            }
            return View(model);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
