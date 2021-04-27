using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Categories.Dto;
using ChefSahar.Service.Application.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Categories.Queries.GetAll
{
    public class GetAllCategoryCommandHandler : BaseCommandHandler<GetAllCategoryCommand, List<CategoryDto>, IBaseRepository<Category>, List<Category>, List<CategoryDto>, string>
    {
        public GetAllCategoryCommandHandler(IBaseRepository<Category> repo, IMapper mapper, ILogger<IBaseRepository<Category>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<CategoryDto>> Handle(GetAllCategoryCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll();

            EntityDto = mapper.Map<List<Category>, List<CategoryDto>>(Entity);

            return EntityDto;
        }
    }
}
