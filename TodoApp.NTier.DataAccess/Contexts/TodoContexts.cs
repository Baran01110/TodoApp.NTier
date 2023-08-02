using Microsoft.EntityFrameworkCore;
using TodoApp.NTier.DataAccess.Configurations;
using TodoApp.NTier.Entities.Domains;

namespace TodoApp.NTier.DataAccess.Contexts
{
    public class TodoContexts : DbContext
    {
        public TodoContexts(DbContextOptions<TodoContexts> options)  : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
        }

        public DbSet<Work> Works { get; set; }
    }
}
