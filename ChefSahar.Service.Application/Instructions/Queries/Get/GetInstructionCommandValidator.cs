using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Queries.Get
{
    public class GetInstructionCommandValidator : AbstractValidator<GetInstructionCommand>
    {
        public GetInstructionCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);

        }
    }
}
