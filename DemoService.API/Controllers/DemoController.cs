using MediatR;
using Microsoft.AspNetCore.Mvc;
using DemoService.Infrastructure.Implementation;
using DemoService.Common.Response;
using DemoService.Application.Client.Queries.DemoDataQuery;

namespace DemoService.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DemoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DemoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(nameof(Greetings))]
        public async Task<ActionResult<Response<Demo>>> Greetings([FromQuery] int id)
        {
            var response = await _mediator.Send(id);
            return Ok(response);
        }

        [HttpPost(nameof(Greetings))]
        public async Task<ActionResult<Response<Demo>>> Greetings([FromBody] GetDemoDataQuery query)
        {
            var response = await _mediator.Send(query);
            return Ok(response);
        }

    }
}
