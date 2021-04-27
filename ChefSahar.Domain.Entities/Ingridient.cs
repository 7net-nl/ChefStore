using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Domain.Entities
{
    public class Ingridient : Entity
    {
        public string Amount { get; set; }
        public long Product_ID { get; set; }

    }
}
