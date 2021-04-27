using ChefSahar.Service.Application.Instructions.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Update
{
    public class UpdateInstructionValidator : InstructionValidator<UpdateInstructionCommand>
    {
        public UpdateInstructionValidator()
        {
            RuleFor(c => c.Product_ID).GreaterThan(0);
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
