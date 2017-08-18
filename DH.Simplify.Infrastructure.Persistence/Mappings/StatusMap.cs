using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            // Table
            ToTable("Status");

            // Key
            HasKey(x => x.StatusId);

            // Fields
            Property(x => x.StatusId);
            Property(x => x.StatusName).IsRequired();
            Property(x => x.StatusDescription);

            // Relationship
            HasMany(e => e.HelpDeskTickets)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);
        }
    }
}
