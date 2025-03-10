using Microsoft.EntityFrameworkCore;
using Assignment.Contracts.Data.Entities;

namespace Assignment.Migrations
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>().AsEnumerable())
            {
                item.Entity.AddedOn = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        
        public DbSet<Users> Users { get; set; }
        public DbSet<SuperAdmin> SuperAdmins { get; set; }
        public DbSet<PanelCoordinator> PanelCoordinators { get; set; }
        public DbSet<PanelMember> PanelMembers { get; set; }
        public DbSet<TARecruiter> TARecruiters { get; set; }
        public DbSet<TAAdmin> TAAdmins { get; set; }
        public DbSet<ReportingManager> ReportingManagers { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Slot> AvailabilitySlots { get; set; }


    }
}