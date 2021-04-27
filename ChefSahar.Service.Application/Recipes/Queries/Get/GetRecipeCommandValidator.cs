using ChefSahar.Service.Application.Recipes.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.Get
{
    public class GetRecipeCommandValidator  : AbstractValidator<GetRecipeCommand>
    {
        public GetRecipeCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).NotNull().GreaterThan(0);
        }
    }
}
