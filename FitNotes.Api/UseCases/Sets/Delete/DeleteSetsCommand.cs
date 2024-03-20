using MediatR;

namespace FitNotes.Api.UseCases.Sets.Delete
{
    public class DeleteSetsCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
