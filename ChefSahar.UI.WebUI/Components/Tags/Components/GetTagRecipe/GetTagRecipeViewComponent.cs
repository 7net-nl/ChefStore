using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Tags.Components.GetTagRecipe
{
    public class GetTagRecipeViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetTagRecipeViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke(long ProductId = 0)
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Tag/All/{ProductId}");

            var model = JsonConvert.DeserializeObject<List<GetTagRecipeViewModel>>(Result);

            return View(model);
        }
    }
}
