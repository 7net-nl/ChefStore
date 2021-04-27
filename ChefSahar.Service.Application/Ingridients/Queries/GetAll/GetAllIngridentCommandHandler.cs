using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Ingridients.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Ingridients.Queries.GetAll
{
    public class GetAllIngridentCommandHandler : BaseCommandHandler<GetAllIngridentCommand, List<IngridientDto>, IBaseRepository<Ingridient>, List<Ingridient>, List<IngridientDto>, string>
    {
        public GetAllIngridentCommandHandler(IBaseRepository<Ingridient> repo, IMapper mapper, ILogger<IBaseRepository<Ingridient>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<IngridientDto>> Handle(GetAllIngridentCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll().Where(c => c.Product_ID == request.Product_ID).OrderBy(c => c.Amount).ToList();

            EntityDto = mapper.Map<List<Ingridient>, List<IngridientDto>>(Entity);

            return EntityDto;
        }
    }
}
