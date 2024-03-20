using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Update
{
    public class UpdateExerciseCommandHandler : IRequestHandler<UpdateExerciseCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public UpdateExerciseCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(UpdateExerciseCommand request, CancellationToken cancellationToken)
        {
            var exercise = await _databaseContext.Exercises.FindAsync(new object[] { request.Id });

            exercise.Name = request.Model.Name;
            exercise.MuscleGroups = request.Model.MuscleGroups;
            exercise.IsMetric = request.Model.IsMetric;
            exercise.Description = request.Model.Description;

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
