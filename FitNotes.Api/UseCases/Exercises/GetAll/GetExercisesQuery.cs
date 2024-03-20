using MediatR;

namespace FitNotes.Api.UseCases.Exercises.GetAll
{
    public class GetExercisesQuery : IRequest<List<GetExercisesModel>>
    {
    }
}
