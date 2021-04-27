using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Categories.Command.Delete
{
    public class DeleteCategoryCommand : EntityDto , IRequest<string>
    {
    }
}
