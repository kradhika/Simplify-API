using DH.Simplify.Core.Domain;
using System.Data.Entity;

namespace DH.Simplify.Infrastructure.Persistence
{
    public class SimplifyContext : DbContext
    {
        public SimplifyContext()
            : base("SimplifyConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SimplifyContext>());
        }

        public virtual DbSet<ContentRecord> ContentRecords { get; set; }

        public virtual DbSet<HelpDeskAttachnment> HelpDeskAttachnments { get; set; }

        public virtual DbSet<HelpDeskTicket> HelpDeskTickets { get; set; }

        public virtual DbSet<MediaAttachment> MediaAttachments { get; set; }

        public virtual DbSet<Provider> Providers { get; set; }

        public virtual DbSet<Speciality> Specialities { get; set; }

        public virtual DbSet<Status> Status { get; set; }

        public virtual DbSet<TermsOfService> TermsOfServices { get; set; }

        public virtual DbSet<UniversalMessage> UniversalMessages { get; set; }

        public virtual DbSet<ContentShare> ContentShares { get; set; }

        public virtual DbSet<HelpDeskTicketHistory> HelpDeskTicketHistories { get; set; }
    }
}
