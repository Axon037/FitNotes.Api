using MediatR;

namespace FitNotes.Api.UseCases.User.Update
{
    public class UpdateUserCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public UpdateUserModel Model { get; set; }
    }
}
