using Microsoft.EntityFrameworkCore;

namespace bajki.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions option) : base(option) 
        { 
            
        }
       


        public DbSet<Tale> Tales { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tale>().ToTable("Tales");
            modelBuilder.Entity<User>().ToTable("Users");
        }

    }
}
