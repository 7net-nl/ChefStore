using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Recipes.Queries.Paging
{
    public class PagingRecipeCommand : IRequest<PagingRecipeCommand>
    {
       
        public short CurrentPage { get; set; }
        public short CountOnPage { get; set; }
        public short TotalPage { get; set; }
    }
}
