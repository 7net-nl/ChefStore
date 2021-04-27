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

namespace ChefSahar.Service.Application.Ingridients.Command.Delete
{
    public class DeleteIngridientsCommandHandler : BaseCommandHandler<DeleteIngridientsCommand, string, IBaseRepository<Ingridient>, Ingridient, IngridientDto, string>
    {
        public DeleteIngridientsCommandHandler(IBaseRepository<Ingridient> repo, IMapper mapper, ILogger<IBaseRepository<Ingridient>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(DeleteIngridientsCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            Result = repo.Delete(Entity);

            return Result;
        }
    }
}
