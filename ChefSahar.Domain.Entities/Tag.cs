using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class Tag : Entity
    {
        public string Name { get; set; }
        public long Product_ID { get; set; }
    }
}
