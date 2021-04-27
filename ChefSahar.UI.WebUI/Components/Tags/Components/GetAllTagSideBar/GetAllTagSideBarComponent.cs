using ChefSahar.UI.WebUI.Components.Categories.Components.GetCategory;
using ChefSahar.UI.WebUI.Components.Tags.Components.GetTagRecipe;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Tags.Components.GetAllTagSideBar
{
    public class GetAllTagSideBarViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetAllTagSideBarViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke()
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Tag/All");

            var model = JsonConvert.DeserializeObject<List<GetTagRecipeViewModel>>(Result);

            return View(model);
        }
    }
}
