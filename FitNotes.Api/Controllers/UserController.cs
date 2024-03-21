using FitNotes.Api.UseCases.User.Add;
using FitNotes.Api.UseCases.User.Delete;
using FitNotes.Api.UseCases.User.GetAll;
using FitNotes.Api.UseCases.User.GetDetails;
using FitNotes.Api.UseCases.User.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FitNotes.Api.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<GetAllUsersModel>>> GetAllUsers(
            [FromServices] IMediator _mediator,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetAllUsersQuery(), cancellationToken);

            return Ok(results);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<GetUserDetailsModel>> GetUserDetails(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetUserDetailsQuery()
            {
                Id = Id
            }, cancellationToken);

            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<AddUserModel>> AddUser(
            [FromServices] IMediator _mediator,
            [FromBody] AddUserModel model,
            CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new AddUserCommand()
            {
                Model = model,
            }, cancellationToken);

            return Ok(results);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteUser(
            [FromServices] IMediator _mediator,
            [FromRoute] Guid Id,
            CancellationToken cancellationToken)
        {
            await _mediator.Send(new DeleteUserCommand()
            {
                Id = Id,
            }, cancellationToken);

            return Ok();
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult> UpdateSets(
        [FromServices] IMediator _mediator,
        [FromRoute] Guid Id,
        [FromBody] UpdateUserModel model,
        CancellationToken cancellationToken)
        {
            await _mediator.Send(new UpdateUserCommand()
            {
                Id = Id,
                Model = model
            }, cancellationToken);

            return Ok();
        }
    }
}
