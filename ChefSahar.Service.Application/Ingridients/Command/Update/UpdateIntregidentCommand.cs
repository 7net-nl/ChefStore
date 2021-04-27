using ChefSahar.Service.Application.Ingridients.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Update
{
    public class UpdateIntregidentCommand : IngridientDto , IRequest<string>
    {
        
    }
}
