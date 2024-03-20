namespace FitNotes.Api.UseCases.Sets.Add
{
    public class AddSetsModel
    {
        public int Weight { get; set; }
        public int Reps { get; set; }
        public bool IsMetric { get; set; }
        public int RPE { get; set; }
        public string? Comment { get; set; }
        public string? Tempo { get; set; }
    }
}
