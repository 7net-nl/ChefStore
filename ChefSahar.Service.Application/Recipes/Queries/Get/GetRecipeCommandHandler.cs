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

namespace ChefSahar.Service.Application.Recipes.Queries.Get
{
    public class GetRecipeCommandHandler : BaseCommandHandler<GetRecipeCommand, RecipeDto, IBaseRepository<Recipe>, Recipe, RecipeDto, string>
    {
        public GetRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<RecipeDto> Handle(GetRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);


            EntityDto = mapper.Map<Recipe, RecipeDto>(Entity);

           

            return EntityDto;
        }
    }
}
