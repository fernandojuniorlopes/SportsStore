using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext(DbContextOptions options) : base(options)//recieve the options to send it to DbContext
        {
        }

        public DbSet<Product> Products { get; set; }//products table
    }
}
