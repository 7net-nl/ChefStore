using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefSahar.Service.Application.Common;
using ChefSahar.Service.Application.Recipes.Command.Create;
using ChefSahar.Service.Application.Recipes.Command.Delete;
using ChefSahar.Service.Application.Recipes.Command.Update;
using ChefSahar.Service.Application.Recipes.Queries.Get;
using ChefSahar.Service.Application.Recipes.Queries.GetAll;
using ChefSahar.Service.Application.Recipes.Queries.LastMany;
using ChefSahar.Service.Application.Recipes.Queries.Paging;
using ChefSahar.Service.Application.Recipes.Queries.Popular;
using ChefSahar.Service.Application.Recipes.Queries.Randoms;
using ChefSahar.Service.Application.Systems.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace chefSahar.UI.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class RecipeController : Controller
    {
        private readonly IMediator mediator;
        private readonly ILogger<RecipeController> logger;

        public RecipeController(IMediator mediator,ILogger<RecipeController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

      [HttpGet("{Id}")]
      public async Task<IActionResult> Get([FromRoute]long Id)
      {
           

            return Ok(await mediator.Send(new GetRecipeCommand { ID = Id }));
      }

         [HttpGet("{currentpage}/{countonpage}")]
         public async Task<IActionResult> Get([FromRoute]GetAllRecipeCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }

        [HttpGet("Populars")]
        public async Task<IActionResult> Get(PopularRecipeCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("Randoms")]
        public async Task<IActionResult> Get([FromRoute]RandomRecipeCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet("Lasts")]
        public async Task<IActionResult> Get([FromRoute]LastManyRecipeCommand command)
        {
            return Ok(await mediator.Send(command));
        }



        [HttpGet("paging/{currentpage}/{countonpage}")]
        public async Task<IActionResult> Get([FromRoute]PagingRecipeCommand command)
        {
          
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateRecipeCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(long Id,[FromBody]UpdateRecipeCommand command)
        {
            if (Id != command.ID)
            {
                logger.LogError("Update Recipe", command.ID, Id);
                throw new InvalidOperationException("id not equal command id");
               
            }

            return Ok(await mediator.Send(command));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute]long Id)
        {
           
            return Ok(await mediator.Send(new DeleteRecipeCommand { ID = Id }));
        }

        [HttpGet("seed")]
        public async Task<IActionResult> Seed([FromRoute] SystemSampleDataCommand command)
        {

            return Ok(await mediator.Send(command));
        }

        [Route("error")]
         public IActionResult Error()
        {
            return BadRequest("System Error, Send Admin, Try Again");
        }
    }
}
