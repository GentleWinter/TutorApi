using Microsoft.EntityFrameworkCore;
using Tutor.Domain.Entities;

namespace Tutor.Infra.Contexts
{
    public class TutorContext : DbContext
    {
        public DbSet<TutorEntity> Tutor { get; set; }

        public TutorContext(DbContextOptions<TutorContext> options) 
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TutorContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
