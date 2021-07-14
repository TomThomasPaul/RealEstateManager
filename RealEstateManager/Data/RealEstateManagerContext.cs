using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstateManager.Models;

namespace RealEstateManager.Data
{
    public class RealEstateManagerContext : DbContext
    {
        public RealEstateManagerContext (DbContextOptions<RealEstateManagerContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstateManager.Models.Listing> Listing { get; set; }
    }
}
