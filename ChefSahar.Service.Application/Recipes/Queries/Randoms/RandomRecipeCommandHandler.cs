using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Recipes.Queries.Randoms
{
    public class RandomRecipeCommandHandler : BaseCommandHandler<RandomRecipeCommand, List<RecipeDto>, IBaseRepository<Recipe>, List<Recipe>, RecipeDto, List<RecipeDto>>
    {
        public RandomRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<RecipeDto>> Handle(RandomRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll().OrderBy(c => new Random().Next()).Take(6).ToList();

            Result = mapper.Map<List<Recipe>, List<RecipeDto>>(Entity);

            return Result;
        }
    }
}
