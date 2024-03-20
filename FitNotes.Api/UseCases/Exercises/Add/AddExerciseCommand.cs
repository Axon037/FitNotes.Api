using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Add
{
    public class AddExerciseCommand : IRequest<Guid>
    {
        public AddExerciseModel Model { get; set; }
    }
}
