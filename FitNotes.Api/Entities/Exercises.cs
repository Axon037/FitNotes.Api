namespace FitNotes.Api.Entities
{
    public class Exercises
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string MuscleGroups { get; set; } = string.Empty;
        public bool IsMetric { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
