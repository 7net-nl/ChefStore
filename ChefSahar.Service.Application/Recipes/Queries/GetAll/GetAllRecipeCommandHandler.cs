using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Dto;
using ChefSahar.Service.Application.Recipes.Queries.Get;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Recipes.Queries.GetAll
{
    public class GetAllRecipeCommandHandler : BaseCommandHandler<GetAllRecipeCommand, List<RecipeDto>, IBaseRepository<Recipe>, List<Recipe>, List<RecipeDto>, string>
    {
        public GetAllRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<RecipeDto>> Handle(GetAllRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll(request.CurrentPage, request.CountOnPage);

            EntityDto = mapper.Map<List<Recipe>, List<RecipeDto>>(Entity);

            return EntityDto;
        }
    }
}
