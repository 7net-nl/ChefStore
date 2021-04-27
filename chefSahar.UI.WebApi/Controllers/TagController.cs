using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefSahar.Service.Application.Categories.Command.Create;
using ChefSahar.Service.Application.Categories.Command.Delete;
using ChefSahar.Service.Application.Categories.Command.Update;
using ChefSahar.Service.Application.Categories.Queries.Get;
using ChefSahar.Service.Application.Categories.Queries.GetAll;
using ChefSahar.Service.Application.Instructions.Command.Create;
using ChefSahar.Service.Application.Instructions.Command.Delete;
using ChefSahar.Service.Application.Instructions.Command.Update;
using ChefSahar.Service.Application.Instructions.Queries.Get;
using ChefSahar.Service.Application.Instructions.Queries.GetAll;
using ChefSahar.Service.Application.Tags.Command.Create;
using ChefSahar.Service.Application.Tags.Command.Delete;
using ChefSahar.Service.Application.Tags.Command.Update;
using ChefSahar.Service.Application.Tags.Queries.Get;
using ChefSahar.Service.Application.Tags.Queries.GetAll;
using ChefSahar.Service.Application.Tags.Queries.GetAllForRecipe;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chefSahar.UI.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class TagController : Controller
    {
        private readonly IMediator mediator;
        private readonly ILogger<TagController> logger;

        public TagController(IMediator mediator, ILogger<TagController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]long Id)
        {
           
            return Ok(await mediator.Send(new GetTagCommand { ID = Id }));
        }

        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
          
            return Ok(await mediator.Send(new GetAllTagCommand()));
        }

        [HttpGet("All/{Id}")]
        public async Task<IActionResult> GetAll(long Id)
        {

            return Ok(await mediator.Send(new GetAllTagForRecipeCommand { Product_ID = Id }));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateTagCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(long Id, [FromBody]UpdateTagCommand command)
        {
            if (Id != command.ID)
            {
                logger.LogError("Update Instruction", command.ID, Id);
                throw new InvalidOperationException("id not equal command id");

            }

           
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute]long Id)
        {
           
            return Ok(await mediator.Send(new DeleteTagCommand { ID = Id }));
        }

       
    }
}
