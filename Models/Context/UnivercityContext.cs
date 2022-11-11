using Microsoft.EntityFrameworkCore;

namespace Models.Context
{
    public class UnivercityContext : DbContext
    {
        public UnivercityContext()
        {
        }

        public UnivercityContext(DbContextOptions<UnivercityContext> opts)
        : base(opts)
        {
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<ChapterModel>? ChapterModel { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=UniversityDB;User=DavidSQLServer;Password=DavidSQLServer;");
            }
        }
    }
}
