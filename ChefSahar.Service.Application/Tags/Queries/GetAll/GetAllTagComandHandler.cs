using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Tags.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Tags.Queries.GetAll
{
    public class GetAllTagComandHandler : BaseCommandHandler<GetAllTagCommand, List<TagDto>, IBaseRepository<Tag>, List<Tag>, List<TagDto>, string>
    {
        public GetAllTagComandHandler(IBaseRepository<Tag> repo, IMapper mapper, ILogger<IBaseRepository<Tag>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<TagDto>> Handle(GetAllTagCommand request, CancellationToken cancellationToken)
        {
            var AllTag = repo.GetAll().OrderBy(c=>new Random().Next()).Distinct().ToList();
            

            Entity = AllTag.Take(5).ToList();

            EntityDto = mapper.Map<List<Tag>, List<TagDto>>(Entity);

            return EntityDto;
        }
    }
}
