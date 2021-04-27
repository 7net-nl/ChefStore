using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Recipes.Command.Delete
{
    public class DeleteRecipeCommandHandler : BaseCommandHandler<DeleteRecipeCommand, string, IBaseRepository<Recipe>, Recipe, DeleteRecipeCommand, string>
    {
        public DeleteRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(DeleteRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            logger.LogInformation("Recipe Delete", Entity);

            Result = repo.Delete(Entity);

            logger.LogInformation("Result Delete", Result);

            return Result;

        }
    }
}
