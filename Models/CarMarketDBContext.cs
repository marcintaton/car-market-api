using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    public class CarMarketDBContext : DbContext
    {
        public CarMarketDBContext(DbContextOptions<CarMarketDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<CarListing> CarListings { get; set; }

        public DbSet<DirectMessage> DirectMessages { get; set; }
    }
}
