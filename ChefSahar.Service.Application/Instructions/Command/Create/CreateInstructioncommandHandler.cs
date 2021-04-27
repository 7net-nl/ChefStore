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

namespace ChefSahar.Service.Application.Instructions.Command.Create
{
    public class CreateInstructioncommandHandler : BaseCommandHandler<CreateInstructionCommand, string, IBaseRepository<Instruction>, Instruction, CreateInstructionCommand, string>
    {
        public CreateInstructioncommandHandler(IBaseRepository<Instruction> repo, IMapper mapper, ILogger<IBaseRepository<Instruction>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(CreateInstructionCommand request, CancellationToken cancellationToken)
        {
            Entity = mapper.Map<InstructionDto, Instruction>(request);

            Result = repo.Add(Entity);

            return Result;
        }
    }
}
