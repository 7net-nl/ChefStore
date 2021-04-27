using ChefSahar.Service.Application.Tags.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Command.Create
{
    public class CreateTagCommand : TagDto , IRequest<string>
    {

    }
}
