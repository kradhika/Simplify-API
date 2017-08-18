using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class MediaAttachmentMap : EntityTypeConfiguration<MediaAttachment>
    {
        public MediaAttachmentMap()
        {
            // Table
            ToTable("MediaAttachment");

            // Key
            HasKey(x => x.MediaAttachmentId);

            // Fields
            Property(x => x.MediaAttachmentId);
            Property(x => x.AttachmentThumbnail);
            Property(x => x.AttachmentSourceId);
            Property(x => x.AttachmentSourceSystem);
            Property(x => x.AttachmentURL);

            // Relationship
            HasMany(e => e.HelpDeskAttachnments)
                .WithRequired(e => e.MediaAttachment)
                .WillCascadeOnDelete(false);
        }
    }
}
