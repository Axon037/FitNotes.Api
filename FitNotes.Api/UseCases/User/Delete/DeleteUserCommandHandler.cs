using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.User.Delete
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly DatabaseContext _databaseContext;

        public DeleteUserCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _databaseContext.User.FindAsync(new object[] { request.Id });

            _databaseContext.User.Remove(user);

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
