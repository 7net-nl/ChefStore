using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Tags.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Tags.Command.Delete
{
    public class DeleteTagCommandHandler : BaseCommandHandler<DeleteTagCommand, string, IBaseRepository<Tag>, Tag, TagDto, string>
    {
        public DeleteTagCommandHandler(IBaseRepository<Tag> repo, IMapper mapper, ILogger<IBaseRepository<Tag>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            Result = repo.Delete(Entity);

            return Result;
        }
    }
}
