namespace FitNotes.Api.UseCases.Sets.GetDetails
{
    public class GetSetsDetailsModel
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public bool IsMetric { get; set; }
        public int RPE { get; set; }
        public string? Comment { get; set; }
        public string? Tempo { get; set; }
        public Guid ExerciseId { get; set; }
        public Guid UserId { get; set; }
    }
}
