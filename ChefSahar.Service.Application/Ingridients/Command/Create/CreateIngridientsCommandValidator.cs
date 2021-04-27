using ChefSahar.Service.Application.Ingridients.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Create
{
    public class CreateIngridientsCommandValidator : IngridientValidator<CreateIngridientsCommand>
    {
        public CreateIngridientsCommandValidator()
        {
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
