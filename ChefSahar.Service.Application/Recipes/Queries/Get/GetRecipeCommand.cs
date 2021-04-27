using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.Get
{
    public class GetRecipeCommand : EntityDto , IRequest<RecipeDto>
    {

    }
}
