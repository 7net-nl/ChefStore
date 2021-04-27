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

namespace ChefSahar.Service.Application.Categories.Command.Update
{
    public class UpdateCategoryCommandHandler : BaseCommandHandler<UpdateCategoryCommand, string, IBaseRepository<Category>, Category, CategoryDto, string>
    {
        public UpdateCategoryCommandHandler(IBaseRepository<Category> repo, IMapper mapper, ILogger<IBaseRepository<Category>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            Entity.Name = request.Name;

            Result = repo.Update(Entity);

            return Result;
        }
    }
}
