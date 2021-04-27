using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Recipes.Command.Create
{
    public class CreateRecipeCommandHandler : BaseCommandHandler<CreateRecipeCommand, string, IBaseRepository<Recipe>, Recipe, RecipeDto, string>
    {
        public CreateRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = mapper.Map<CreateRecipeCommand, Recipe>(request);

            logger.LogInformation("Recipe Add", Entity, request);

            Result = repo.Add(Entity);

            logger.LogInformation("Recipe Add", Result);

            return Result;

        }
    }
}
