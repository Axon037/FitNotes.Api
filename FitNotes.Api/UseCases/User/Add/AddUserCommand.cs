using MediatR;

namespace FitNotes.Api.UseCases.User.Add
{
    public class AddUserCommand : IRequest<Guid>
    {
        public AddUserModel Model { get; set; }
    }
}
