using ChefSahar.Service.Application.Recipes.Dto;
using ChefSahar.UI.WebUI.Components.Recipes.Components.Get;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.GetAll
{
    public class GetAllViewComponent : ViewComponent
    {
        private readonly WebClient client;
        private readonly ILogger<GetAllViewComponent> logger;

        public GetAllViewComponent(WebClient client,ILogger<GetAllViewComponent> logger)
        {
            this.client = client;
            this.logger = logger;
        }
        public IViewComponentResult Invoke(short CurrentPage = 1)
        {
            
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Recipe/{CurrentPage}/10");
            var Recipes = JsonConvert.DeserializeObject<List<GetRecipeViewModel>>(Result);

            logger.LogInformation("GetAll Recipe Component",Result);

            return View(Recipes);
        }
    }
}
