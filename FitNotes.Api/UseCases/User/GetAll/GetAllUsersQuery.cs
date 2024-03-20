using MediatR;

namespace FitNotes.Api.UseCases.User.GetAll
{
    public class GetAllUsersQuery : IRequest<List<GetAllUsersModel>>
    {
    }
}
