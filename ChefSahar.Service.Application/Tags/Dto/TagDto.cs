using ChefSahar.Service.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Dto
{
    public class TagDto : EntityDto
    {
        public string Name { get; set; }
        public long Product_ID { get; set; }
    }
}
