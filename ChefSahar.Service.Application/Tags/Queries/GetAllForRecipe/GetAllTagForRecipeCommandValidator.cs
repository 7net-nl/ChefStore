using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Queries.GetAllForRecipe
{
    public class GetAllTagForRecipeCommandValidator : AbstractValidator<GetAllTagForRecipeCommand>
    {
        public GetAllTagForRecipeCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
