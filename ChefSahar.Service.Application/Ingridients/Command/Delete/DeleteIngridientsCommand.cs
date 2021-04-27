using ChefSahar.Service.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Delete
{
    public class DeleteIngridientsCommand  : EntityDto , IRequest<string>
    {
        
    }
}
