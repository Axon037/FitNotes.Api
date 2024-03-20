using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Add
{
    public class AddExerciseCommandHandler : IRequestHandler<AddExerciseCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public AddExerciseCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(AddExerciseCommand request, CancellationToken cancellationToken)
        {
            var exerciseId = Guid.NewGuid();

            await _databaseContext.Exercises.AddAsync(new Entities.Exercises
            {
                Id = exerciseId,
                Name = request.Model.Name,
                MuscleGroups = request.Model.MuscleGroups,
                IsMetric = request.Model.IsMetric,
                Description = request.Model.Description,
            });

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return exerciseId;
        }
    }
}
