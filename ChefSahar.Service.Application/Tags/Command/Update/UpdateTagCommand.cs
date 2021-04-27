using ChefSahar.Service.Application.Tags.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Update
{
    public class UpdateTagCommand : TagDto , IRequest<string>
    {

    }
}
