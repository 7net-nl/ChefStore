using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Queries.Get
{
    public class GetIngridentCommandValidator : AbstractValidator<GetIngridentcommand>
    {
        public GetIngridentCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
