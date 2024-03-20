using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Update
{
    public class UpdateExerciseCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public UpdateExerciseModel Model { get; set; }
    }
}
