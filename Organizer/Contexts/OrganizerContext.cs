using Microsoft.EntityFrameworkCore;
using Organizer.Entities;

namespace Organizer.Contexts
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrganizerContext, Configuration>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\eformity.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
    }
}