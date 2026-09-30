using Microsoft.EntityFrameworkCore;
using HctNetCoreLab12_EF.Models;
namespace HctNetCoreLab12_EF.HctEntities
{
    public class HctAppDBContext : DbContext
    {
        public HctAppDBContext(DbContextOptions<HctAppDBContext> options) : base(options)
        {
        }

        public DbSet<HctProduct> HctProducts { get; set; }
        public DbSet<HctCategory> HctCategories { get; set; }
    }
}
