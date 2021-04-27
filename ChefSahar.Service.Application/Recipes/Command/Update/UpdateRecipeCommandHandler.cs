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

namespace ChefSahar.Service.Application.Recipes.Command.Update
{
    public class UpdateRecipeCommandHandler : BaseCommandHandler<UpdateRecipeCommand, string, IBaseRepository<Recipe>, Recipe, UpdateRecipeCommand, string>
    {
        public UpdateRecipeCommandHandler(IBaseRepository<Recipe> repo, IMapper mapper, ILogger<IBaseRepository<Recipe>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(UpdateRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            if (Entity == null) throw new InvalidOperationException($"Recipe Find And Update Error not Found Entity {Entity.ObjectToString()} and {request.ObjectToString()}");

            Entity.ID = request.ID;
            Entity.CookTime = request.CookTime;
            Entity.Description = request.Description;
            Entity.ImageUrl = request.ImageUrl;
            Entity.NumberServing = request.NumberServing;
            Entity.TimePrep = request.TimePrep;
            Entity.Title = request.Title;
            Entity.VideoUrl = request.VideoUrl;

            Result = repo.Update(Entity);

            logger.LogInformation("Update Recipe",Result, Entity, request);

            return Result;



        }
    }
}
