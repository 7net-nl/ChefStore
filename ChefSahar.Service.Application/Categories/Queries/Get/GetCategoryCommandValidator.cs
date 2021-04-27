using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Queries.Get
{
    public class GetCategoryCommandValidator : AbstractValidator<GetCategoryCommand>
    {
        public GetCategoryCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
