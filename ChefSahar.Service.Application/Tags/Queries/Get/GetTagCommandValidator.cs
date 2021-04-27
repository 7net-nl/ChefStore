using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Queries.Get
{
    public class GetTagCommandValidator : AbstractValidator<GetTagCommand>
    {
        public GetTagCommandValidator()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);

        }
    }
}
