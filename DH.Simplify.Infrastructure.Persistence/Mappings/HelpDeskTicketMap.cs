using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class HelpDeskTicketMap : EntityTypeConfiguration<HelpDeskTicket>
    {
        public HelpDeskTicketMap()
        {
            // Table
            ToTable("HelpDeskTicket");

            // Key
            HasKey(x => x.HelpDeskTicketId);

            // Fields
            Property(x => x.HelpDeskTicketId);
            Property(x => x.HelpDeskTicketGuid).IsRequired();
            Property(x => x.Title).IsRequired();
            Property(x => x.Description).IsUnicode(false);
            Property(x => x.ProviderId).IsRequired();
            Property(x => x.CreatedOn).IsRequired().HasColumnType("datetime2");
            Property(x => x.UpdatedOn).IsRequired().HasColumnType("datetime2");
            Property(x => x.StatusId).IsRequired();
        }
    }
}
