using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Command.Delete
{
    public class DeleteRecipeCommandValidator : AbstractValidator<DeleteRecipeCommand>
    {
        public DeleteRecipeCommandValidator()
        {
            RuleFor(c => c.ID).GreaterThan(0).NotNull();
            RuleFor(c => c).NotNull();
        }
    }
}
