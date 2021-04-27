using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Command.Delete
{
    public class DeleteRecipeCommand : EntityDto, IRequest<string>
    {

    }
}
