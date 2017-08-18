using System.Data.Entity.ModelConfiguration;
using DH.Simplify.Core.Domain;

namespace DH.Simplify.Infrastructure.Persistence.Mappings
{
    public class TermsOfServiceMap : EntityTypeConfiguration<TermsOfService>
    {
        public TermsOfServiceMap()
        {
            // Table
            ToTable("TermsOfService");

            // Key
            HasKey(x => x.TermsOfServiceId);

            // Fields
            Property(x => x.TermsOfServiceId);
            Property(x => x.Description).IsRequired().IsUnicode(false);
            Property(x => x.Version);
        }
    }
}
