using Microsoft.EntityFrameworkCore;

namespace MaiBinhAn_2310900001.Models
{
    public class MbaDbContext : DbContext
    {
        public MbaDbContext(DbContextOptions<MbaDbContext> options) : base(options) { }

        public DbSet<MbaEmployee> MbaEmployee { get; set; }
    }
}
