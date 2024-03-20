using FitNotes.Api.Entities;

namespace FitNotes.Api.UseCases.Exercises.Add
{
    public class AddExerciseModel
    {
        public string Name { get; set; }
        public string MuscleGroups { get; set; }
        public bool IsMetric { get; set; }
        public string Description { get; set; }
    }
}
