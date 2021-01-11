using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vaida_Cecilia.Models;

namespace Vaida_Cecilia.Data
{
    public class Vaida_CeciliaContext : DbContext
    {
        public Vaida_CeciliaContext (DbContextOptions<Vaida_CeciliaContext> options)
            : base(options)
        {
        }

        public DbSet<Vaida_Cecilia.Models.Car> Car { get; set; }

        public DbSet<Vaida_Cecilia.Models.Publisher> Publisher { get; set; }

        public DbSet<Vaida_Cecilia.Models.Category> Category { get; set; }
    }
}
