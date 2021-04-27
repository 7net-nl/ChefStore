using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Dto
{
    public class CategoryDtoValidator<TCommand> : AbstractValidator<CategoryDto> where TCommand : CategoryDto
    {
        public CategoryDtoValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.Name.Length).GreaterThan(3).LessThan(10);
            

        }
    }
}
