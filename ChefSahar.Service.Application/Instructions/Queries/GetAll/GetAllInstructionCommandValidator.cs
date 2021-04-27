using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Queries.GetAll
{
    public class GetAllInstructionCommandValidator : AbstractValidator<GetAllInstructioncommand>
    {
        public GetAllInstructionCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
