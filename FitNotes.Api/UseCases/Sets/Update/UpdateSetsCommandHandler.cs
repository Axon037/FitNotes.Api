using FitNotes.Api.Data;
using FitNotes.Api.UseCases.Exercises.Update;
using MediatR;

namespace FitNotes.Api.UseCases.Sets.Update
{
    public class UpdateSetsCommandHandler : IRequestHandler<UpdateSetsCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public UpdateSetsCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(UpdateSetsCommand request, CancellationToken cancellationToken)
        {
            var sets = await _databaseContext.Sets.FindAsync(new object[] { request.Id });

            sets.Weight = request.Model.Weight;
            sets.Reps = request.Model.Reps;
            sets.IsMetric = request.Model.IsMetric;
            sets.RPE = request.Model.RPE;
            sets.Comment = request.Model.Comment;
            sets.Tempo = request.Model.Tempo;

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
