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

namespace ChefSahar.Service.Application.Categories.Command.Delete
{
    public class DeleteCategorycommandHandler : BaseCommandHandler<DeleteCategoryCommand, string, IBaseRepository<Category>, Category, CategoryDto, string>
    {
        public DeleteCategorycommandHandler(IBaseRepository<Category> repo, IMapper mapper, ILogger<IBaseRepository<Category>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request);

            Result = repo.Delete(Entity);

            return Result;
        }
    }
}
