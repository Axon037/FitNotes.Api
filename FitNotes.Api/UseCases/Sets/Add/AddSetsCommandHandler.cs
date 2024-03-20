using FitNotes.Api.Data;
using FitNotes.Api.UseCases.Exercises.Add;
using MediatR;

namespace FitNotes.Api.UseCases.Sets.Add
{
    public class AddSetsCommandHandler : IRequestHandler<AddSetsCommand, Guid>
    {
        private readonly DatabaseContext _databaseContext;

        public AddSetsCommandHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Guid> Handle(AddSetsCommand request, CancellationToken cancellationToken)
        {
            var setsId = Guid.NewGuid();

            await _databaseContext.Sets.AddAsync(new Entities.Sets
            {
                Id = setsId,
                Weight = request.Model.Weight,
                Reps = request.Model.Reps,
                IsMetric = request.Model.IsMetric,
                RPE = request.Model.RPE,
                Comment = request.Model.Comment,
                Tempo = request.Model.Tempo
            });

            await _databaseContext.SaveChangesAsync(cancellationToken);

            return setsId;
        }
    }
}
