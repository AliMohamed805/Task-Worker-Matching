using Microsoft.EntityFrameworkCore;
using Task_Worker_Matching.Models;
// Use a clearer alias to avoid confusion with System.Threading.Tasks.Task
using TaskModel = Task_Worker_Matching.Models.Task;

namespace Task_Worker_Matching.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<TaskModel> Tasks { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<WorkerSpecialty> WorkerSpecialties { get; set; } = null!;
        public DbSet<TimeSlot> TimeSlots { get; set; } = null!;
        public DbSet<WorkerLocation> WorkerLocations { get; set; } = null!;
        public DbSet<Experience> Experiences { get; set; } = null!;
        public DbSet<Feedback> Feedbacks { get; set; } = null!;
        public DbSet<CanDo> CanDos { get; set; } = null!;
        public DbSet<Requires> Requires { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite keys
            modelBuilder.Entity<WorkerLocation>()
                .HasKey(wl => new { wl.Location, wl.WorkerId });

            modelBuilder.Entity<Experience>()
                .HasKey(e => new { e.WorkerId, e.SpecialtyId });

            modelBuilder.Entity<CanDo>()
                .HasKey(cd => new { cd.TaskId, cd.WorkerId });

            modelBuilder.Entity<Requires>()
                .HasKey(r => new { r.TaskId, r.SpecialtyId });

            modelBuilder.Entity<Feedback>()
                .HasKey(f => new { f.ClientId, f.WorkerId, f.RequestId, f.FromClient });

            // Configure relationships
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Client)
                .WithMany(c => c.Requests)
                .HasForeignKey(r => r.ClientId);

            // Fix: Use string navigation property name to avoid lambda confusion
            modelBuilder.Entity<Request>()
                .HasOne("Task")
                .WithMany("Requests")
                .HasForeignKey("TaskId");
        }
    }
}