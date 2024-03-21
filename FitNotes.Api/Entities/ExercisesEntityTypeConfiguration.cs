using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitNotes.Api.Entities
{
    public class ExercisesEntityTypeConfiguration : IEntityTypeConfiguration<Exercises>
    {
        public void Configure(EntityTypeBuilder<Exercises> builder) 
        {
            builder
                .HasOne(x => x.Users)
                .WithMany(x => x.Exercises)
                .HasForeignKey(x => x.Users.Id);
        }
    }
}
