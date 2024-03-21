using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.Sets.GetDetails
{
    public class GetSetsDetailsQueryHandler : IRequestHandler<GetSetsDetailsQuery, GetSetsDetailsModel>
    {
        private readonly DatabaseContext _databaseContext;

        public GetSetsDetailsQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<GetSetsDetailsModel> Handle(GetSetsDetailsQuery request, CancellationToken cancellationToken)
        {
            var set = await _databaseContext.Sets
            .Where(x => x.Id == request.Id)
            .Select(x => new GetSetsDetailsModel()
            {
                Id = x.Id,
                Weight = x.Weight,
                Reps = x.Reps,
                IsMetric = x.IsMetric,
                RPE = x.RPE,
                Comment = x.Comment,
                Tempo = x.Tempo,
                ExerciseId = x.Exercises.Id,
                UserId = x.Users.Id
            })
            .FirstOrDefaultAsync(cancellationToken);
            return set;
        }
    }
}
