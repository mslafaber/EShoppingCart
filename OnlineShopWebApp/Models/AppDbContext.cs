using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class AppDbContext:DbContext
    {
        //following method will create Dbcontext options and apply to the appdbcontext class
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        //specify which entities will be manages by dbsontext
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
