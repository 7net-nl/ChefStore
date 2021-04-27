using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Categories.Dto;
using ChefSahar.Service.Application.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Categories.Queries.Get
{
    public class GetCategoryCommandHandler : BaseCommandHandler<GetCategoryCommand, CategoryDto, IBaseRepository<Category>, Category, CategoryDto, string>
    {
        public GetCategoryCommandHandler(IBaseRepository<Category> repo, IMapper mapper, ILogger<IBaseRepository<Category>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<CategoryDto> Handle(GetCategoryCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            EntityDto = mapper.Map<Category, CategoryDto>(Entity);

            return EntityDto;
        }
    }
}
