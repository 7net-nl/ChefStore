using ChefSahar.UI.WebUI.Components.Ingridents.Components.GetIngrident;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.Get
{
    public class GetViewComponent : ViewComponent
    {
        private readonly ILogger<GetViewComponent> logger;
        private readonly WebClient client;

        public GetViewComponent(ILogger<GetViewComponent> logger, WebClient client)
        {
            this.logger = logger;
            this.client = client;
        }

        public IViewComponentResult Invoke(long Id= 0)
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Recipe/{Id}");
            var model = JsonConvert.DeserializeObject<GetRecipeViewModel>(Result);

            ViewBag.ImageRecipe = model.ImageUrl;

            return View(model);
        }
    }
}
