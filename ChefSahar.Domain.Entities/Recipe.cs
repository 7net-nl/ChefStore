using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class Recipe : Entity
    {
       
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
        public byte TimePrep { get; set; }
        public byte CookTime { get; set; }
        public byte NumberServing { get; set; }
        public string Description { get; set; }
        public long Category_ID { get; set; }


    }
}
