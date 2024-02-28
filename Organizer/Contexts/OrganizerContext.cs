using Microsoft.EntityFrameworkCore;
using Organizer.Entities;

namespace Organizer.Contexts
{
    public class OrganizerContext : DbContext
    {
        // public OrganizerContext()
        // {
        //     Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrganizerContext, Configuration>());
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=Server=tcp:eformity-organizer.database.windows.net,1433;Initial Catalog=eformity-organizer;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=""Active Directory Default"";");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
    }
}