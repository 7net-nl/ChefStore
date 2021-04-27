using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Instructions.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Instructions.Queries.GetAll
{
    public class GetInstructionCommandHandler : BaseCommandHandler<GetAllInstructioncommand, List<InstructionDto>, IBaseRepository<Instruction>,List<Instruction>, List<InstructionDto>, string>
    {
        public GetInstructionCommandHandler(IBaseRepository<Instruction> repo, IMapper mapper, ILogger<IBaseRepository<Instruction>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<List<InstructionDto>> Handle(GetAllInstructioncommand request, CancellationToken cancellationToken)
        {
            Entity = repo.GetAll().Where(c => c.Product_ID == request.Product_ID).OrderBy(c => c.Step).ToList();

            if (Entity == null) throw new InvalidOperationException($"Can't find Instructions for {request} Id : {request.Product_ID}");

            EntityDto = mapper.Map<List<Instruction>, List<InstructionDto>>(Entity);

            return EntityDto;
        }
    }
}
