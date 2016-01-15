﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ItemDbInitializer : DropCreateDatabaseAlways<ItemContext>
    {
        protected override void Seed(ItemContext context)
        {
            //context.Products.Add(new Item() { Id = 1, Name = "Product 1", Price = 10 });
            //context.Products.Add(new Item() { Id = 2, Name = "Product 2", Price = 20 });
            //context.Products.Add(new Product() { Id = 3, Name = "Product 3", Price = 30 });
            //context.Products.Add(new Product() { Id = 4, Name = "Product 4", Price = 40 });

            base.Seed(context);
        }
    }
}