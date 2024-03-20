using FitNotes.Api.UseCases.Sets.Add;
using FitNotes.Api.UseCases.Sets.Delete;
using FitNotes.Api.UseCases.Sets.GetAll;
using FitNotes.Api.UseCases.Sets.GetDetails;
using FitNotes.Api.UseCases.Sets.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitNotes.Api.Controllers
{
    [ApiController]
    [Route("Sets")]
    public class SetsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetSetsModel>>> GetAllSets(
            [FromServices] IMediator _mediator,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetSetsQuery(), cancellationToken);

            return Ok(results);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<GetSetsDetailsModel>> GetSetDetails(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetSetsDetailsQuery()
            {
                Id = Id
            }, cancellationToken);

            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<AddSetsModel>> AddSets(
            [FromServices] IMediator _mediator,
            [FromBody] AddSetsModel model,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new AddSetsCommand()
            {
                Model = model,
            }, cancellationToken);

            return Ok(results);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteSets(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            await _mediator.Send(new DeleteSetsCommand()
            {
                Id = Id,
            }, cancellationToken);

            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateSets(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            [FromBody] UpdateSetsModel model,
            CancellationToken cancellationToken)
        {
            await _mediator.Send(new UpdateSetsCommand()
            {
                Id = Id,
                Model = model
            }, cancellationToken);

            return Ok();
        }
    }
}

