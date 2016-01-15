using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext()
            : base("ItemConnection")
        {
        }
        public DbSet<Computers> Comp{ get; set; }
        public DbSet<Laptop> Lap { get; set; }
    }
}