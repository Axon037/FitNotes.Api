using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.Sets.GetAll
{
    public class GetSetsQueryHandler : IRequestHandler<GetSetsQuery, List<GetSetsModel>>
    {
        private readonly DatabaseContext _databaseContext;

        public GetSetsQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<GetSetsModel>> Handle(GetSetsQuery request, CancellationToken cancellationToken)
        {
            var setsList = await _databaseContext.Sets
            .Select(x => new GetSetsModel()
            {
                Id = x.Id,
                Weight = x.Weight,
                Reps = x.Reps,
                IsMetric = x.IsMetric
            }).ToListAsync(cancellationToken);
            return setsList;
        }
    }
}
