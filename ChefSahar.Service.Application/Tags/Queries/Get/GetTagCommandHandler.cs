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

namespace ChefSahar.Service.Application.Tags.Queries.Get
{
    public class GetTagCommandHandler : BaseCommandHandler<GetTagCommand, TagDto, IBaseRepository<Tag>, Tag, TagDto, string>
    {
        public GetTagCommandHandler(IBaseRepository<Tag> repo, IMapper mapper, ILogger<IBaseRepository<Tag>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<TagDto> Handle(GetTagCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            EntityDto = mapper.Map<Tag, TagDto>(Entity);

            return EntityDto;
        }
    }
}
