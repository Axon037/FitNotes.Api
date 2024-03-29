﻿using FitNotes.Api.UseCases.Exercises.Add;
using FitNotes.Api.UseCases.Exercises.Delete;
using FitNotes.Api.UseCases.Exercises.GetAll;
using FitNotes.Api.UseCases.Exercises.GetDetails;
using FitNotes.Api.UseCases.Exercises.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitNotes.Api.Controllers
{
    [ApiController]
    [Route("Exercises")]
    public class ExercisesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetExercisesModel>>> GetAllExercises(
            [FromServices] IMediator _mediator,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetExercisesQuery(), cancellationToken);

            return Ok(results);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<GetDetailsModel>> GetExercisesDetail(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetDetailsQuery()
            {
                Id = Id
            }, cancellationToken);

            //if(results is null)
            //{
            //    return NotFound(results);
            //}
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<AddExerciseModel>> AddExercise(
            [FromServices] IMediator _mediator,
            [FromBody] AddExerciseModel model,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new AddExerciseCommand()
            {
                Model = model,
            }, cancellationToken);

            return Ok(results);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteExercise(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            await _mediator.Send(new DelExerciseCommand()
            {
                Id = Id,
            }, cancellationToken);

            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateExercise(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            [FromBody] UpdateExerciseModel model,
            CancellationToken cancellationToken)
        {
            await _mediator.Send(new UpdateExerciseCommand()
            {
                Id = Id,
                Model = model
            }, cancellationToken);

            return Ok();
        }
    }
}

// Ctrl + K, Ctrl + C - comment
// Ctrk + K, Ctrl + U - uncomment