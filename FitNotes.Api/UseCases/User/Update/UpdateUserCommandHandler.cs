using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.User.Update
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public UpdateUserCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var sets = await _databaseContext.User.FindAsync(new object[] { request.Id });

            sets.Name = request.Model.Name;
            sets.Password = request.Model.Password;
            sets.Email = request.Model.Email;

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
