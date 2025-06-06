using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetAllAboutQuery;

namespace OnionArchitectureRentACarBook.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AboutsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAbout()
    {
        var query = new GetAllAboutQueryRequest();
        var result  = await _mediator.Send(query);
        if(result.Result.IsSuccess)
        {
            return Ok(result.Result.Data);
        }
        return BadRequest(result.Result.Message);
    }
}
