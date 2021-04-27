using ChefSahar.Service.Application.Tags.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Update
{
    public class UpdateTagCommandValidator : TagDtoValidator<UpdateTagCommand>
    {
        public UpdateTagCommandValidator()
        {
            RuleFor(c => c.Product_ID).GreaterThan(0);
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
