using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Delete
{
    public class DeleteTagCommand : EntityDto , IRequest<string>
    {

    }
}
