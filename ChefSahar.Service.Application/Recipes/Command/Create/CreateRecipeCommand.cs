
using ChefSahar.Service.Application.Recipes.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Command.Create
{
    public class CreateRecipeCommand : RecipeDto,IRequest<string>
    {

    }
}
