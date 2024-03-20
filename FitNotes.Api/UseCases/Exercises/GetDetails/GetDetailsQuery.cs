using FitNotes.Api.UseCases.User.GetDetails;
using MediatR;

namespace FitNotes.Api.UseCases.Exercises.GetDetails
{
    public class GetDetailsQuery : IRequest<GetDetailsModel>
    {
        public Guid Id { get; set; }
        public GetUserDetailsModel Details { get; set; }
    }
}
