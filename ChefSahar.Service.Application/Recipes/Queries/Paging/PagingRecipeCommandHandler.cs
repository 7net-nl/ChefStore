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

namespace ChefSahar.Service.Application.Recipes.Queries.Paging
{
    public class PagingRecipeCommandHandler : BaseCommandHandler<PagingRecipeCommand, PagingRecipeCommand, IBaseRepository<Recipe>, Recipe, RecipeDto, short>
    {
        public PagingRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<PagingRecipeCommand> Handle(PagingRecipeCommand request, CancellationToken cancellationToken)
        {
            var Count = repo.GetAll().Count();

            var TotalPage = Count / (double)request.CountOnPage;

            request.TotalPage = (short)Math.Ceiling(TotalPage);

            return request;

        }
    }
}
