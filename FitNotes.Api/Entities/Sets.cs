namespace FitNotes.Api.Entities
{
    public class Sets
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public bool IsMetric { get; set; }
        public int RPE { get; set; }
        public string? Comment { get; set; }
        public string? Tempo { get; set; }
        public virtual Exercises Exercises { get; set; }
        public virtual Users Users { get; set; }
    }
}
