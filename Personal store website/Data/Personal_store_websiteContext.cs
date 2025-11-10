using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal_store_website.Models;

namespace Personal_store_website.Data
{
    public class Personal_store_websiteContext : DbContext
    {
        public Personal_store_websiteContext (DbContextOptions<Personal_store_websiteContext> options)
            : base(options)
        {
        }

        public DbSet<Personal_store_website.Models.Product> Product { get; set; } = default!;
    }
}
