using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace Auction.DataAccess.Context
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
