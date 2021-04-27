using ChefSahar.Service.Application.Instructions.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Create
{
    public class CreateInstructionValidator : InstructionValidator<CreateInstructionCommand>
    {
        public CreateInstructionValidator()
        {
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
