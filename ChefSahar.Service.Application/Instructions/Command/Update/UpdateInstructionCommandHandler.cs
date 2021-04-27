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

namespace ChefSahar.Service.Application.Instructions.Command.Update
{
    public class UpdateInstructionCommandHandler : BaseCommandHandler<UpdateInstructionCommand, string, IBaseRepository<Instruction>, Instruction, UpdateInstructionCommand, string>
    {
        public UpdateInstructionCommandHandler(IBaseRepository<Instruction> repo, IMapper mapper, ILogger<IBaseRepository<Instruction>> logger) : base(repo, mapper, logger)
        {
        }

        public async override Task<string> Handle(UpdateInstructionCommand request, CancellationToken cancellationToken)
        {
            Entity = repo.Find(request.ID);

            if (Entity == null) throw new InvalidOperationException($"Can't Update Because Not find Entity {request} with Id : {request.ID}");

            Entity.Description = request.Description;
            Entity.ImageUrl = request.ImageUrl;
            Entity.Step = request.Step;

            Result = repo.Update(Entity);

            return Result;
            

        }
    }
}
