using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Tags.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Queries.Get
{
    public class GetTagCommand : EntityDto , IRequest<TagDto>
    {

    }
}
