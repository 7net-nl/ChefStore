using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class Instruction : Entity
    {
        public string Step { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public long Product_ID { get; set; }
    }
}
