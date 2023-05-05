using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Persistence
{
    public class CarsDbContextFactory: IDesignTimeDbContextFactory<CarsDbContext>
    {
        public CarsDbContext CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
