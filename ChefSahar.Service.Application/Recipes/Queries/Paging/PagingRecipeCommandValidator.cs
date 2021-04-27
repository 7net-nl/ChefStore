using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.Paging
{
    public class PagingRecipeCommandValidator : AbstractValidator<PagingRecipeCommand>
    {
        public PagingRecipeCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.CountOnPage).Must(GreatthanShort).WithMessage("CountOnPage Great Than 0");
            RuleFor(c => c.CurrentPage).Must(GreatthanShort).WithMessage("CurrentPage Great Than 0");
           

        }

        private bool GreatthanShort(short arg)
        {
           return arg > 0 ? true : false;
        }
    }
}
