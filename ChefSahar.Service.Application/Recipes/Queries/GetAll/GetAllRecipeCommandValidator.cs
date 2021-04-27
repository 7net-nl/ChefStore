using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.GetAll
{
    public class GetAllRecipeCommandValidator : AbstractValidator<GetAllRecipeCommand>
    {
        public GetAllRecipeCommandValidator()
        {
            RuleFor(c => c).NotNull();
        }
    }
}
