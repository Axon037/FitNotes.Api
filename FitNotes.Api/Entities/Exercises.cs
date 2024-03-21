namespace FitNotes.Api.Entities
{
    public class Exercises
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MuscleGroups { get; set; }
        public bool IsTime { get; set; }
        public string? Description { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Sets> Sets { get; set; }
    }
}
