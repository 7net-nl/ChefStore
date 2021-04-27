using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class RecipeInfo : Entity
    {
        public DateTime InsertDate { get; set; }
        public string InsertBy { get; set; }
        public string ImageProfile { get; set; }
        public byte RankStar { get; set; }
        public byte RankNumber { get; set; }
        public int Like { get; set; }
        public long Recipe_ID { get; set; }
        public int Views { get; set; }
    }
}
