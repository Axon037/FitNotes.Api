using MediatR;

namespace FitNotes.Api.UseCases.Sets.Update
{
    public class UpdateSetsCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public UpdateSetsModel Model { get; set; }
    }
}
