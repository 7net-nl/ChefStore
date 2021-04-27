using ChefSahar.UI.WebUI.Components.Categories.Components.GetCategory;
using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Categories.Components.GetAllSideBar
{
    public class GetAllSideBarViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetAllSideBarViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke()
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Category/All");

            var model = JsonConvert.DeserializeObject<List<GetCategoryViewModel>>(Result);

            return View(model);
        }
    }
}
