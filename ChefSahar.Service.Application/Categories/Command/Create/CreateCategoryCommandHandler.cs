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

namespace ChefSahar.Service.Application.Categories.Command.Create
{
    public class CreateCategoryCommandHandler : BaseCommandHandler<CreateCategoryCommand, string, IBaseRepository<Category>, Category, CategoryDto, string>
    {
        public CreateCategoryCommandHandler(IBaseRepository<Category> repo, IMapper mapper, ILogger<IBaseRepository<Category>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Entity = mapper.Map<CategoryDto, Category>(request);

            Result = repo.Add(Entity);

            return Result;
        }
    }
}
