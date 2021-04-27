using ChefSahar.Service.Application.Tags.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Queries.GetAll
{
    public class GetAllTagCommand : IRequest<List<TagDto>>
    {
    }
}
