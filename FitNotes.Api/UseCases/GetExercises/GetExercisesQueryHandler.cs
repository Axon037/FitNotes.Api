using FitNotes.Api.Data;
using FitNotes.Api.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FitNotes.Api.UseCases.GetExercises
{
    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, List<Exercises>>
    {      
            private readonly DatabaseContext _databaseContext;

        public GetExercisesQueryHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<List<Exercises>> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
            {
                var a = _databaseContext.Exercises.ToList();
                _databaseContext.SaveChanges();
                return a;
                //return Task.FromResult(request.Description);
            }
    }
}
