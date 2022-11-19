using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ENOC.data
{
    public class ENOCContext:DbContext
    {
        public DbSet<Facilities> facilities { get; set; }
        public DbSet<SiteFacilities> siteFacilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost; initial catalog=EnocDb; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
