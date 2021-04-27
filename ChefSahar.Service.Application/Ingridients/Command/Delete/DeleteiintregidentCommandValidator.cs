using ChefSahar.Service.Application.Ingridients.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Delete
{
    public class DeleteiintregidentCommandValidator : AbstractValidator<DeleteIngridientsCommand>
    {
        public DeleteiintregidentCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
