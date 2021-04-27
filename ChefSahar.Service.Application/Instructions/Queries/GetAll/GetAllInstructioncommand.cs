using ChefSahar.Service.Application.Instructions.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Queries.GetAll
{
    public class GetAllInstructioncommand : IRequest<List<InstructionDto>>
    {
        public long Product_ID { get; set; }
    }
}
