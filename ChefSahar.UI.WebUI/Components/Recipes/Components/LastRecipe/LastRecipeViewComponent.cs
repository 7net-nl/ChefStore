using ChefSahar.UI.WebUI.Components.Recipes.Components.Get;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.LastRecipe
{
    public class LastRecipeViewComponent : ViewComponent
    {

        
        private readonly WebClient client;

        public LastRecipeViewComponent(WebClient client)
        {
            
            this.client = client;
        }

        public IViewComponentResult Invoke()
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Recipe/Lasts");
            var model = JsonConvert.DeserializeObject<List<GetRecipeViewModel>>(Result);

           

            return View(model.LastOrDefault());
        }
    }
}
