using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Ingridients.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Ingridients.Command.Update
{
    public class UpdateIngridentComandHandler : BaseCommandHandler<UpdateIntregidentCommand, string, IBaseRepository<Ingridient>, Ingridient, IngridientDto, string>
    {
        public UpdateIngridentComandHandler(IBaseRepository<Ingridient> repo, IMapper mapper, ILogger<IBaseRepository<Ingridient>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(UpdateIntregidentCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            Entity.Amount = request.Amount;

            Result = repo.Update(Entity);

            return Result;



        }
    }
}
