using ChefSahar.Service.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Dto
{
    public class RecipeDto : EntityDto
    {
   

        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
        public byte TimePrep { get; set; }
        public byte CookTime { get; set; }
        public byte NumberServing { get; set; }
        public int Views { get; set; }
        public string Description { get; set; }
        public long Category_ID { get; set; }
    }
}
