using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
    public class ProductoContext : DbContext
    {
        public ProductoContext (DbContextOptions<ProductoContext> options)
            : base(options)
        {
        }

        public DbSet<Shop.Models.Productos> Productos { get; set; }
    }
}
