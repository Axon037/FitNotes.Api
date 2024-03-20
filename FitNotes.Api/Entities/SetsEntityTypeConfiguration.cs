using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitNotes.Api.Entities
{
    public class SetsEntityTypeConfiguration : IEntityTypeConfiguration<Sets>
    {
        public void Configure(EntityTypeBuilder<Sets> builder) 
        {
            builder
                .HasOne(x => x.Exercises)
                .WithMany(x => x.Sets)
                .HasForeignKey(x => x.Exercises.Id);
        }
    }
}
