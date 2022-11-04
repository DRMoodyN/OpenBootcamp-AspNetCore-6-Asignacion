using System;

namespace UnivercityApiBackend.DataAccess.Context
{
    public class UniverstityDbContext : DbContext
    {
        public UniverstityDbContext(DbContextOptions<UniverstityDbContext> opts)
        : base(opts)
        {

        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<ChapterModel>? ChapterModel { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<User>? Users { get; set; }

    }
}
