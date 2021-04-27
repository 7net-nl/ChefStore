using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Dto
{
    public class IngridientValidator<TCommand> : AbstractValidator<TCommand> where TCommand:IngridientDto
    {
        public IngridientValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Amount).NotEmpty();
            RuleFor(c => c.Amount.Length).GreaterThan(3).LessThan(500);

        }
    }
}
