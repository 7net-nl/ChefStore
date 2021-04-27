using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.Paging
{
    public class PagingViewModel
    {
        public short CurrentPage { get; set; }
        public short CountOnPage { get; set; }
        public short TotalPage { get; set; }
    }
}
