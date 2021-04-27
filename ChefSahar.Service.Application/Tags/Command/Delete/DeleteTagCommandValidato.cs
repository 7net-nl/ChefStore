using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Delete
{
    public class DeleteTagCommandValidato : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagCommandValidato()
        {
            RuleFor(c => c).NotNull();
            RuleFor(c => c.ID).GreaterThan(0);
        }
    }
}
