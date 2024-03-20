using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.User.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<GetAllUsersModel>>
    {
        private readonly DatabaseContext _databaseContext;

        public GetAllUsersQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<GetAllUsersModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var setsList = await _databaseContext.User
            .Select(x => new GetAllUsersModel()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email
            }).ToListAsync(cancellationToken);
            return setsList;
        }
    }
}
