using ChefSahar.Service.Application.Tags.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Create
{
    public class CreateTagCommandValidator : TagDtoValidator<CreateTagCommand>
    {
        public CreateTagCommandValidator()
        {
            RuleFor(c => c.Product_ID).GreaterThan(0);
        }
    }
}
