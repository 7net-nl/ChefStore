using ChefSahar.Service.Application.Tags.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Tags.Queries.GetAllForRecipe
{
    public class GetAllTagForRecipeCommand : IRequest<List<TagDto>>
    {
        public long Product_ID { get; set; }
    }
}
