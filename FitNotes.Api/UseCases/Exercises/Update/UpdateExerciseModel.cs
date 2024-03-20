namespace FitNotes.Api.UseCases.Exercises.Update
{
    public class UpdateExerciseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MuscleGroups { get; set; }
        public bool IsMetric { get; set; }
        public string Description { get; set; }
    }
}
