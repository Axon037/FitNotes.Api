using MediatR;

namespace FitNotes.Api.UseCases.User.GetDetails
{
    public class GetUserDetailsQuery : IRequest<GetUserDetailsModel>
    {
        public Guid Id { get; set; }
    }
}
