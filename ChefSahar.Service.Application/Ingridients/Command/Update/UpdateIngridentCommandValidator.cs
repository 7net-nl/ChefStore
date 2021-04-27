using ChefSahar.Service.Application.Ingridients.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Update
{
    public class UpdateIngridentCommandValidator : IngridientValidator<UpdateIntregidentCommand>
    {
        public UpdateIngridentCommandValidator()
        {
            RuleFor(c => c.ID).GreaterThan(0);
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
