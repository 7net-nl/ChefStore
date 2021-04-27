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

namespace ChefSahar.Service.Application.Ingridients.Queries.Get
{
    public class GetIngridentCommandHandler : BaseCommandHandler<GetIngridentcommand, IngridientDto, IBaseRepository<Ingridient>, Ingridient, IngridientDto, string>
    {
        public GetIngridentCommandHandler(IBaseRepository<Ingridient> repo, IMapper mapper, ILogger<IBaseRepository<Ingridient>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<IngridientDto> Handle(GetIngridentcommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            EntityDto = mapper.Map<Ingridient, IngridientDto>(Entity);

            return EntityDto;
        }
    }
}
