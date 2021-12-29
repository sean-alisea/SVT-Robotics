using Microsoft.EntityFrameworkCore;
using Sample1.Models.Output;

namespace Sample1.Repository.Data
{
    public class RobotDbContext : DbContext
    {
        public DbSet<Robot> Categories { get; set; }
    }
}
