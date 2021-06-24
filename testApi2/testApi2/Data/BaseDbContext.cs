using Microsoft.EntityFrameworkCore;
using testApi2.Models;

namespace testApi2.Data
{
    public class BaseDbContext : DbContext
    {

        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Event> Events { get; set; }
    }
}
