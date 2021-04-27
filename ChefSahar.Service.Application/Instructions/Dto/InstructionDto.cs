using ChefSahar.Service.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Dto
{
    public class InstructionDto : EntityDto
    {
        public string Step { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public long Product_ID { get; set; }
    }
}
