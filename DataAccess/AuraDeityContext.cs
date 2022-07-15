using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AuraDeityContext : DbContext
    {
        public AuraDeityContext(DbContextOptions<AuraDeityContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<UserAuthEntity> UserAuths { get; set; }
        public DbSet<WeatherDataEntity> WeatherDatas { get; set; }
    }
}