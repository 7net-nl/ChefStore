using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Command.Create
{
    public class CreateRecipeValidator : RecipeDtoValidator<CreateRecipeCommand>
    {
        public CreateRecipeValidator()
        {
            RuleFor(c => c.Category_ID).GreaterThan(0);
        }
    }
}
