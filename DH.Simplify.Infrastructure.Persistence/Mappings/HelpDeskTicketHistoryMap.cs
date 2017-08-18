using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class HelpDeskTicketHistoryMap : EntityTypeConfiguration<HelpDeskTicketHistory>
    {
        public HelpDeskTicketHistoryMap()
        {
            // Table
            ToTable("HelpDeskTicketHistory");

            // Key
            HasKey(x => x.HelpDeskTicketHistoryId);

            // Fields
            Property(x => x.HelpDeskTicketHistoryId);
            Property(x => x.HelpDeskTicketId).IsRequired();
            Property(x => x.RemedyDescription).IsUnicode(false);
            Property(x => x.RemedyStatus);
        }
    }
}
