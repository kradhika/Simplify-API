using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class ContentRecordMap : EntityTypeConfiguration<ContentRecord>
    {
        public ContentRecordMap()
        {
            // Table
            ToTable("ContentRecord");

            // Key
            HasKey(x => x.ContentId);

            // Fields
            Property(x => x.ContentId);
            Property(x => x.Title).IsRequired();
            Property(x => x.Description).IsRequired().IsUnicode(false);
            Property(x => x.URL);
            Property(x => x.CreatedOn).HasColumnType("datetime2");
            Property(x => x.CreatedBy);

            // Relationship
            HasMany(e => e.UniversalMessages)
                .WithRequired(e => e.ContentRecord)
                .WillCascadeOnDelete(false);

            HasMany(e => e.MediaAttachments)
                .WithMany(e => e.ContentRecords)
                .Map(m => m.ToTable("ContentAttachment").MapLeftKey("ContentId").MapRightKey("MediaAttachmentId"));
        }
    }
}
