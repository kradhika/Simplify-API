using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class UniversalMessageMap : EntityTypeConfiguration<UniversalMessage>
    {
        public UniversalMessageMap()
        {
            // Table
            ToTable("UniversalMessage");

            // Key
            HasKey(x => x.MessageId);

            // Fields
            Property(x => x.MessageId);
            Property(x => x.ContentId).IsRequired();
            Property(x => x.MessageLiveDate).HasColumnType("datetime2");
            Property(x => x.MessageDeacitvatedDate).HasColumnType("datetime2");
            Property(x => x.CreatedOn).HasColumnType("datetime2");
            Property(x => x.CreatedBy);
        }
    }
}
