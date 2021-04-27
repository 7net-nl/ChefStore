using ChefSahar.Service.Application.Ingridients.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Command.Create
{
    public class CreateIngridientsCommand : IngridientDto , IRequest<string>
    {

    }
}
