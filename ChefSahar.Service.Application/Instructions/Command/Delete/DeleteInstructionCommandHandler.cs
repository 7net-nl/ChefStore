using AutoMapper;
using ChefSahar.Domain.Contract.Repositories;
using ChefSahar.Domain.Entities;
using ChefSahar.Service.Application.Common;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChefSahar.Service.Application.Instructions.Command.Delete
{
    public class DeleteInstructionCommandHandler : BaseCommandHandler<DeleteInstructionCommand, string, IBaseRepository<Instruction>, Instruction, DeleteInstructionCommand, string>
    {
        public DeleteInstructionCommandHandler(IBaseRepository<Instruction> repo, IMapper mapper, ILogger<IBaseRepository<Instruction>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(DeleteInstructionCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            if (Entity == null) throw new InvalidOperationException($"Can't Find Id {request.ID} For Delete");

            Result = repo.Delete(Entity);

            return Result;
        }
    }
}
