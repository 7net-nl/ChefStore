using ChefSahar.UI.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Instructions.Components.GetInstruction
{
    public class GetInstructionViewComponent : ViewComponent
    {
        private readonly WebClient client;

        public GetInstructionViewComponent(WebClient client)
        {
            this.client = client;
        }
        public IViewComponentResult Invoke(long ProductId=1)
        {
            client.Headers.Add("content-type", "application/json");
            var Result = client.DownloadString($"{ApiUrl.Url}/Instruction/all/{ProductId}");

            var model = JsonConvert.DeserializeObject<List<GetInstructionViewModel>>(Result);

            return View(model);
        }
    }
}
