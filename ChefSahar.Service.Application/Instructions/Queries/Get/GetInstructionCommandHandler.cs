using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Instructions.Dto;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Instructions.Queries.Get
{
    public class GetInstructionCommandHandler : BaseCommandHandler<GetInstructionCommand, InstructionDto, IBaseRepository<Instruction>, Instruction, InstructionDto, string>
    {
        public GetInstructionCommandHandler(IBaseRepository<Instruction> repo, IMapper mapper, ILogger<IBaseRepository<Instruction>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<InstructionDto> Handle(GetInstructionCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            if (Entity == null) throw new InvalidOperationException($"Can't find ID : {request.ID} Entity : {request}");

            EntityDto = mapper.Map<Instruction, InstructionDto>(Entity);

            return EntityDto;

        }
    }
}
