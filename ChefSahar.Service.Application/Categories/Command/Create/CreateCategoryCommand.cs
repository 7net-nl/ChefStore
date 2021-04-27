using ChefSahar.Service.Application.Categories.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Command.Create
{
    public class CreateCategoryCommand : CategoryDto , IRequest<string>
    {

    }
}
