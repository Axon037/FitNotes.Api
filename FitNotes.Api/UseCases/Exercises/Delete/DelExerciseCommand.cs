using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Delete
{
    public class DelExerciseCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
