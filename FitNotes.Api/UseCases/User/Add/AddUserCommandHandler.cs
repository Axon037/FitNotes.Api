using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.User.Add
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public AddUserCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var UserId = Guid.NewGuid();

            await _databaseContext.User.AddAsync(new Entities.Users
            {
                Id = UserId,
                Name = request.Model.Name,
                Password = request.Model.Password,
                Email = request.Model.Email
            });

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return UserId;
        }
    }
}
