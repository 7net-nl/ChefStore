using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.Paging
{
    public class PagingViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public PagingViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke(short CurrentPage = 1)
        {
            var Result = client.DownloadString($"{ApiUrl.Url}/Recipe/paging/{CurrentPage}/10");
            var Paging = JsonConvert.DeserializeObject<PagingViewModel>(Result);

            return View(Paging);
        }
    }
}
