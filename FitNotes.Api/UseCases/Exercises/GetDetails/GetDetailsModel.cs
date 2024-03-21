using FitNotes.Api.Entities;

namespace FitNotes.Api.UseCases.Exercises.GetDetails
{
    public class GetDetailsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MuscleGroups { get; set; }
        public bool IsMetric { get; set; }
        public string? Description { get; set; }
        public Guid CreatedByUserId { get; set; }
    }
}
