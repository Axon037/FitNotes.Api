using MediatR;

namespace FitNotes.Api.UseCases.Sets.GetAll
{
    public class GetSetsQuery : IRequest<List<GetSetsModel>>
    {
    }
}
