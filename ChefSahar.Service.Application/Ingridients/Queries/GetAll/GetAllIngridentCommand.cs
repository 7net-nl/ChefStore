using ChefSahar.Service.Application.Ingridients.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Ingridients.Queries.GetAll
{
    public class GetAllIngridentCommand : IRequest<List<IngridientDto>>
    {
        public long Product_ID { get; set; }
    }
}
