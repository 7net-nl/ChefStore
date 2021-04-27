using ChefSahar.Service.Application.Recipes.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.LastMany
{
    public class LastManyRecipeCommand : IRequest<List<RecipeDto>>
    {

    }
}
