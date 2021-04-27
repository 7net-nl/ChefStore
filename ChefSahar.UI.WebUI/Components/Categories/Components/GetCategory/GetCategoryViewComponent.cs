using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Categories.Components.GetCategory
{
    public class GetCategoryViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetCategoryViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke(long CategoryId=0)
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Category/{CategoryId}");

            var model = JsonConvert.DeserializeObject<GetCategoryViewModel>(Result);

            return View(model);
        }
    }
}
