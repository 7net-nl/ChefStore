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

namespace ChefSahar.Service.Application.Ingridients.Command.Create
{
    public class CreateIngridientsCommandHandler : BaseCommandHandler<CreateIngridientsCommand,string, IBaseRepository<Ingridient>, Ingridient, IngridientDto, string>
    {
        public CreateIngridientsCommandHandler(IBaseRepository<Ingridient> repo, IMapper mapper, ILogger<IBaseRepository<Ingridient>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(CreateIngridientsCommand request, CancellationToken cancellationToken)
        {
            Entity = mapper.Map<IngridientDto, Ingridient>(request);

            Result = repo.Add(Entity);

            return Result;
        }
    }
}
