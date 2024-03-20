using MediatR;

namespace FitNotes.Api.UseCases.User.Delete
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
