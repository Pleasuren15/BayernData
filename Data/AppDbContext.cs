using Microsoft.EntityFrameworkCore;

namespace BayernData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
    }
}
