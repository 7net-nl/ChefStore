﻿using ChefSahar.Service.Application.Recipes.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.Randoms
{
    public class RandomRecipeCommand : IRequest<List<RecipeDto>>
    {
    }
}
