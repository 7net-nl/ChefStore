using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using ChefSahar.Service.Application.Recipes.Queries.Get;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.GetAll
{
    public class GetAllRecipeCommand : EntityDto , IRequest<List<RecipeDto>>
    {
        public short CountOnPage { get; set; }
        public short CurrentPage { get; set; }
    }
}
