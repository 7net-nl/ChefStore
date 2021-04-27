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

namespace ChefSahar.Service.Application.Tags.Command.Create
{
    public class CreateTagCommandHandler : BaseCommandHandler<CreateTagCommand,string,IBaseRepository<Tag>,Tag,TagDto,string>
    {
        public CreateTagCommandHandler(IBaseRepository<Tag> repo, IMapper mapper, ILogger<IBaseRepository<Tag>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            Entity = mapper.Map<TagDto, Tag>(request);

            Result = repo.Add(Entity);

            return Result;
        }
    }
}
