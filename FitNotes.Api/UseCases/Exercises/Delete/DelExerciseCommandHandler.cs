
using FitNotes.Api.Data;
using MediatR;

namespace FitNotes.Api.UseCases.Exercises.Delete
{
    public class DelExerciseCommandHandler : IRequestHandler<DelExerciseCommand, Unit>
    {
        private readonly DatabaseContext _databaseContext;

        public DelExerciseCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Unit> Handle(DelExerciseCommand request, CancellationToken cancellationToken)
        {
            //_databaseContext.Exercises
            //    .Where(x => x.Id == request.Id)
            //    .Remove();

            var exercise = await _databaseContext.Exercises.FindAsync(new object[]{ request.Id });

            _databaseContext.Exercises.Remove(exercise);

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
