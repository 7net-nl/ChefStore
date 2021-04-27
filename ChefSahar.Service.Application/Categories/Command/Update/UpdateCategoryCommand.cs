using ChefSahar.Service.Application.Categories.Dto;
using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Command.Update
{
    public class UpdateCategoryCommand : CategoryDto , IRequest<string>
    {

    }
}
