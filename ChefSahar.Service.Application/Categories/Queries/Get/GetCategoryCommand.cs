using ChefSahar.Service.Application.Categories.Dto;
using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Queries.Get
{
    public class GetCategoryCommand : EntityDto , IRequest<CategoryDto>
    {
       
    }
}
