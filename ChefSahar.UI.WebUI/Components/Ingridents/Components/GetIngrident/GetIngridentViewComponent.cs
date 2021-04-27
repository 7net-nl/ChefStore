using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Ingridents.Components.GetIngrident
{
    public class GetIngridentViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetIngridentViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke(long ProductId=0)
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/ingrident/all/{ProductId}");

           var model = JsonConvert.DeserializeObject<List<GetIngridentViewModel>>(Result);

            return View(model);
        }
    }
}
