using MediatR;

namespace FitNotes.Api.UseCases.GetExercises
{
    public class GetExercisesQuery : IRequest<string>
    { 
        public bool IsMetric { get; set; }
        public string Description { get; set; } = string.Empty;
        public GetExercisesModel Body { get; set; }
    }
}
