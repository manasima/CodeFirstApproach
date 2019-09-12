using mis.data.Models;
using Microsoft.EntityFrameworkCore;

namespace mis.data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}