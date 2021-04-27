using ChefSahar.Service.Application.Recipes.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Command.Update
{
    public class UpdateRecipeCommandValidation : RecipeDtoValidator<UpdateRecipeCommand>
    {
        public UpdateRecipeCommandValidation()
        {
            RuleFor(c => c.Category_ID).GreaterThan(0);
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
