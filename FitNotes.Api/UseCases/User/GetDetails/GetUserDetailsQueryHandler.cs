using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.User.GetDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, GetUserDetailsModel>
    {
        private readonly DatabaseContext _databaseContext;

        public GetUserDetailsQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<GetUserDetailsModel> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var user = await _databaseContext.User
            .Where(x => x.Id == request.Id)
            .Select(x => new GetUserDetailsModel()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Password = x.Password
            })
            .FirstOrDefaultAsync(cancellationToken);
            return user;
        }
    }
}
