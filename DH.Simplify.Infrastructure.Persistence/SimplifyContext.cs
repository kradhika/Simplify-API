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
    }
}
