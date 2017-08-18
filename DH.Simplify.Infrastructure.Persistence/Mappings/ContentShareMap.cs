using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class ContentShareMap : EntityTypeConfiguration<ContentShare>
    {
        public ContentShareMap()
        {
            // Table
            ToTable("ContentShare");

            // Key
            HasKey(x => x.ContentShareId);

            // Fields
            Property(x => x.ContentShareId);
            Property(x => x.ContentId).IsRequired();
            Property(x => x.SpecialityId).IsRequired();
            Property(x => x.CreatedOn).IsRequired().HasColumnType("datetime2");
            Property(x => x.CreatedBy).IsRequired();
        }
    }
}
