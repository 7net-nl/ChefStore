using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Ingridients.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Queries.Get
{
    public class GetIngridentcommand : EntityDto , IRequest<IngridientDto>
    {

    }
}
