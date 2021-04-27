using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ChefSahar.Service.Application.Recipes.Dto;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChefSahar.UI.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
         
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult Recipes(short CurrentPage = 1)
        {
            
            return View(CurrentPage);
        }

        public IActionResult About()
        {
            

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult RecipeDetail(long Id=0)
        {
            return View(Id);
        }

        [Route("404")]
        public IActionResult Page404()
        {
            return View("404");
        }

        [Route("Error")]
        public IActionResult Error()
        {
            var Errors = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            logger.LogError(Errors.Error.Message, Errors.Path);

            return View();

        }
    }
}
