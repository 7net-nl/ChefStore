using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefSahar.UI.WebUI.Components.Recipes.Components.CreateRecipe
{
    public class RecipeViewModel
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
        public byte TimePrep { get; set; }
        public byte CookTime { get; set; }
        public byte NumberServing { get; set; }
        public int Views { get; set; }
        public string Description { get; set; }
    }
}
