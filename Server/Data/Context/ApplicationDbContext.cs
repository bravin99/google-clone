using Microsoft.EntityFrameworkCore;
using GoogleClone.Shared.Models;

namespace GoogleClone.Server.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<ResultObject>? GoogleSets { get; set; }
    }
}