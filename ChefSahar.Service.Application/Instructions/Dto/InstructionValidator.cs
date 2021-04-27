using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Dto
{
    public class InstructionValidator<TCommand> : AbstractValidator<TCommand> where TCommand:InstructionDto
    {

        public InstructionValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description.Length).GreaterThan(0).LessThan(4000);
            RuleFor(c => c.ImageUrl).NotEmpty();
            RuleFor(c => c.ImageUrl.Length).GreaterThan(3).LessThan(1000);
            RuleFor(c => c.Step).NotEmpty();
            RuleFor(c => c.Step.Length).GreaterThan(2).LessThan(20);

        }
    }
}
