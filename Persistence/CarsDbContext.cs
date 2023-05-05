using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Persistence
{
    public class CarsDbContext : DbContext
    {
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}