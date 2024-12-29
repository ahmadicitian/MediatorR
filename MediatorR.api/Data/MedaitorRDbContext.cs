using MediatorR.api.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatorR.api.Data
{
    public class MedaitorRDbContext : DbContext
    {
        public MedaitorRDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
    }
}
