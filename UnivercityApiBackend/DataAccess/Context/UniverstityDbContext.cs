using System;

namespace UnivercityApiBackend.DataAccess.Context
{
    public class UniverstityDbContext : DbContext
    {
        public UniverstityDbContext(DbContextOptions<UniverstityDbContext> opts)
        : base(opts)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
