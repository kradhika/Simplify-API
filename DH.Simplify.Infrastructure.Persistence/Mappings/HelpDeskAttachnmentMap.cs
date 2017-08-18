using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class HelpDeskAttachnmentMap : EntityTypeConfiguration<HelpDeskAttachnment>
    {
        public HelpDeskAttachnmentMap()
        {
            // Table
            ToTable("HelpDeskAttachnment");

            // Key
            HasKey(x => x.HelpDeskTicketId);

            // Fields
            Property(x => x.HelpDeskTicketId);
            Property(x => x.MediaAttachmentId).IsRequired();

            // Relationship
            HasOptional(e => e.HelpDeskTicket)
                .WithRequired(e => e.HelpDeskAttachnment);
        }
    }
}
