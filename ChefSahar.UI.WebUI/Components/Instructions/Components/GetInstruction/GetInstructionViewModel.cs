using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Instructions.Components.GetInstruction
{
    public class GetInstructionViewModel
    {
        public long ID { get; set; }
        public string Step { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public long Product_ID { get; set; }

    }
}
