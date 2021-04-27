using AutoMapper;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Categories.Dto;
using ChefSahar.Service.Application.Ingridients.Dto;
using ChefSahar.Service.Application.Instructions.Dto;
using ChefSahar.Service.Application.Recipes.Command.Update;
using ChefSahar.Service.Application.Recipes.Dto;
using ChefSahar.Service.Application.Recipes.Queries.Get;
using ChefSahar.Service.Application.Tags.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Common
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<UpdateRecipeCommand, Recipe>().ReverseMap();
            CreateMap<InstructionDto, Instruction>().ReverseMap();
            CreateMap<IngridientDto, Ingridient>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<TagDto, Tag>().ReverseMap();

        }
    }
}
