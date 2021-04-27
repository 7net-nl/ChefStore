using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefSahar.Service.Application.Ingridients.Command.Create;
using ChefSahar.Service.Application.Ingridients.Command.Delete;
using ChefSahar.Service.Application.Ingridients.Command.Update;
using ChefSahar.Service.Application.Ingridients.Queries.Get;
using ChefSahar.Service.Application.Ingridients.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chefSahar.UI.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class IngridentController : Controller
    {
        private readonly IMediator mediator;
        private readonly ILogger<IngridentController> logger;

        public IngridentController(IMediator mediator, ILogger<IngridentController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]long Id)
        {
          
            return Ok(await mediator.Send(new GetIngridentcommand { ID = Id }));
        }

        [HttpGet("All/{Id}")]
        public async Task<IActionResult> GetAll([FromRoute]long Id)
        {
           
            return Ok(await mediator.Send(new GetAllIngridentCommand { Product_ID = Id }));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateIngridientsCommand command)
        {
           
            return Ok(await mediator.Send(command));
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(long Id, [FromBody]UpdateIntregidentCommand command)
        {
            if (Id != command.ID)
            {
                logger.LogError("Update ingrident", command.ID, Id);
                throw new InvalidOperationException("id not equal command id");

            }

           
            return Ok(await mediator.Send(command));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute]long Id)
        {
           
            return Ok(await mediator.Send(new DeleteIngridientsCommand { ID = Id }));
        }

      
    }
}
