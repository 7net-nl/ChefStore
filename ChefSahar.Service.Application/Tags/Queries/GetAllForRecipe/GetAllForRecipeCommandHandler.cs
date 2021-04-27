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

namespace ChefSahar.Service.Application.Tags.Queries.GetAllForRecipe
{
    public class GetAllForRecipeCommandHandler : BaseCommandHandler<GetAllTagForRecipeCommand, List<TagDto>, IBaseRepository<Tag>, List<Tag>, List<TagDto>, string>
    {
        public GetAllForRecipeCommandHandler(IBaseRepository<Tag> repo, IMapper mapper, ILogger<IBaseRepository<Tag>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<TagDto>> Handle(GetAllTagForRecipeCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll().Where(c => c.Product_ID == request.Product_ID).OrderBy(c => c.Name).ToList();

            EntityDto = mapper.Map<List<Tag>, List<TagDto>>(Entity);

            return EntityDto;
        }
    }
}
