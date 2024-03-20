using MediatR;

namespace FitNotes.Api.UseCases.Sets.GetDetails
{
    public class GetSetsDetailsQuery : IRequest<GetSetsDetailsModel>
    {
        public Guid Id { get; set; }
    }
}
