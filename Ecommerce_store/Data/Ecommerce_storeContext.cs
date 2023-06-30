using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerce_store.Models;

namespace Ecommerce_store.Data
{
    public class Ecommerce_storeContext : DbContext
    {
        public Ecommerce_storeContext (DbContextOptions<Ecommerce_storeContext> options)
            : base(options)
        {
        }

        public DbSet<Ecommerce_store.Models.Category>? Category { get; set; } = default!;

        public DbSet<Ecommerce_store.Models.Product>? Product { get; set; }

        public DbSet<Ecommerce_store.Models.Account>? Account { get; set; }
    }
}
