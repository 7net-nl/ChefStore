using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Queries.GetAll
{
    public class GetAllIngridentCommandValidator : AbstractValidator<GetAllIngridentCommand>
    {
        public GetAllIngridentCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
