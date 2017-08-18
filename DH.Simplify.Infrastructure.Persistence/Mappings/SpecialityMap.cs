using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class SpecialityMap : EntityTypeConfiguration<Speciality>
    {
        public SpecialityMap()
        {
            // Table
            ToTable("Speciality");

            // Key
            HasKey(x => x.SpecialityId);

            // Fields
            Property(x => x.SpecialityId);
            Property(x => x.SpecialityName).IsRequired();
            Property(x => x.CreatedOn).IsRequired().HasColumnType("datetime2");
            Property(x => x.CreatedBy).IsRequired();

            // Relationship
            HasMany(e => e.ContentShares)
                .WithRequired(e => e.Speciality)
                .WillCascadeOnDelete(false);
        }
    }
}
