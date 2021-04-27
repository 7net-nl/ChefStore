using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Instructions.Command.Delete
{
    public class DeleteInstructionCommand : EntityDto , IRequest<string>
    {

    }
}
