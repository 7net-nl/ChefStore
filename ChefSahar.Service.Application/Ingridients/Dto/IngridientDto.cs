using ChefSahar.Service.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Dto
{
    public class IngridientDto : EntityDto
    {
        public string Amount { get; set; }
        public long Product_ID { get; set; }
    }
}
