using ChefSahar.Service.Application.Categories.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Queries.GetAll
{
    public class GetAllCategoryCommand : IRequest<List<CategoryDto>>
    {
        
    }
}
