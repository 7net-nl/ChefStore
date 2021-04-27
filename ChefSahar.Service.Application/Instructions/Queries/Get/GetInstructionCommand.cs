using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Instructions.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Queries.Get
{
    public class GetInstructionCommand : EntityDto , IRequest<InstructionDto>
    {
    }
}
