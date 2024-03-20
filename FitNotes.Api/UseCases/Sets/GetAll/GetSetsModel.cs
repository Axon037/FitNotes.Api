namespace FitNotes.Api.UseCases.Sets.GetAll
{
    public class GetSetsModel
    {
        public Guid Id { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public bool IsMetric { get; set; }
    }
}
