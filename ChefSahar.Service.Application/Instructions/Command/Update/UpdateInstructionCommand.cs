using ChefSahar.Service.Application.Instructions.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Update
{
    public class UpdateInstructionCommand : InstructionDto , IRequest<string>
    {

    }
}
