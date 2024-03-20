using MediatR;

namespace FitNotes.Api.UseCases.Sets.Add
{
    public class AddSetsCommand : IRequest<Guid>
    {
        public AddSetsModel Model { get; set; }
    }
}
