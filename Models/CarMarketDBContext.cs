using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMarket.Models
{
    ///
    /// Context class representing the database structure
    ///
    public class CarMarketDBContext : DbContext
    {
        public CarMarketDBContext(DbContextOptions<CarMarketDBContext> options) : base(options)
        {

        }

        ///
        /// Collection representing users table
        ///
        public DbSet<User> Users { get; set; }

        ///
        /// Collection representing listings table
        ///
        public DbSet<CarListing> CarListings { get; set; }

        ///
        /// Collection representing messages table
        ///
        public DbSet<DirectMessage> DirectMessages { get; set; }
    }
}
