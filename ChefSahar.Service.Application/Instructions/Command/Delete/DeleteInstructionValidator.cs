using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Delete
{
    public class DeleteInstructionValidator : AbstractValidator<DeleteInstructionCommand>
    {
        public DeleteInstructionValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);

        }
    }
}
