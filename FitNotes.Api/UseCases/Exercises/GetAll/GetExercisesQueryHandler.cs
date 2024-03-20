using FitNotes.Api.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FitNotes.Api.UseCases.Exercises.GetAll
{
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, List<GetExercisesModel>>
    {
        private readonly DatabaseContext _databaseContext;

        public GetExercisesQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<GetExercisesModel>> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
        {
            var exercisesList = await _databaseContext.Exercises
            .Select(x => new GetExercisesModel()
            {
                Id = x.Id,
                Name = x.Name,
                MuscleGroups = x.MuscleGroups
            }).ToListAsync(cancellationToken);
            return exercisesList;
        }
    }
}
