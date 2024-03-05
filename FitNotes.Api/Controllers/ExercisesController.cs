using FitNotes.Api.Entities;
using FitNotes.Api.UseCases.GetExercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitNotes.Api.Controllers
{
    [ApiController]
    [Route("test")]
    public class ExercisesController : ControllerBase
    {
        [HttpPost("getRandomGuid/{description}/{isMetric}")]
        public async Task<ActionResult<List<Exercises>>> GetRandomGuid([FromServices] IMediator _mediator,
            [FromRoute]
            bool isMetric,
            string description,
            [FromBody] GetExercisesModel body,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetExercisesQuery()
            {
                IsMetric = isMetric,
                Description = description,
                Body = body
            });

            return Ok(results);
        }
    }
}

// Ctrl + K, Ctrl + C - comment
// Ctrk + K, Ctrl + U - uncomment