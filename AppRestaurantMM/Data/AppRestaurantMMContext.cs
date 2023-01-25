using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppRestaurantMM.Models;

namespace AppRestaurantMM.Data
{
    public class AppRestaurantMMContext : DbContext
    {
        public AppRestaurantMMContext (DbContextOptions<AppRestaurantMMContext> options)
            : base(options)
        {
        }

        public DbSet<AppRestaurantMM.Models.Menu> Menu { get; set; } = default!;
    }
}
