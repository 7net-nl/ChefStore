using ChefSahar.Service.Application.Instructions.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Create
{
    public class CreateInstructionCommand : InstructionDto , IRequest<string>
    {
        
    }
}
