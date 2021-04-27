using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Dto
{
    public class TagDtoValidator<TCommand> : AbstractValidator<TCommand> where TCommand : TagDto
    {
        public TagDtoValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Name.Length).GreaterThan(0).LessThan(10);
        }
    }
}
