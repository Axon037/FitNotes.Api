using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.Exercises.GetDetails
{
    public class GetDetailsQueryHandler : IRequestHandler<GetDetailsQuery, GetDetailsModel>
    {
        private readonly DatabaseContext _databaseContext;

        public GetDetailsQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<GetDetailsModel> Handle(GetDetailsQuery request, CancellationToken cancellationToken)
        {
            var exercise = await _databaseContext.Exercises
            .Where(x => x.Id == request.Id)
            .Select(x => new GetDetailsModel()
            {
                Id = x.Id,
                Name = x.Name,
                MuscleGroups = x.MuscleGroups,
                IsMetric = x.IsMetric,
                Description = x.Description,
            })
            .FirstOrDefaultAsync(cancellationToken);
            return exercise;
        }
    }
}
