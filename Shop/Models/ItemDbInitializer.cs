using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class ItemDbInitializer : DropCreateDatabaseIfModelChanges<ItemContext>
    {
        protected override void Seed(ItemContext context)
        {
            context.Comp.Add(new Computers() { ImagesPath = "/Content/Images/img1.jpg", Firm = "HP", Number = 1234567, Сharacteristics = "Частота процессора и тд и тп" });
            context.Comp.Add(new Computers() { ImagesPath = "/Content/Images/img2.jpg", Firm = "Lenovo", Number = 1234563, Сharacteristics = "Частота процессора и тд и тп" });
            context.Comp.Add(new Computers() { ImagesPath = "/Content/Images/img4.jpg", Firm = "ASUS", Number = 1234343, Сharacteristics = "Частота процессора и тд и тп" });
            context.Comp.Add(new Computers() { ImagesPath = "/Content/Images/img2.jpg", Firm = "Aser", Number = 1234563, Сharacteristics = "Частота процессора и тд и тп" });
            context.Comp.Add(new Computers() { ImagesPath = "/Content/Images/img2.jpg", Firm = "Aser", Number = 123, Сharacteristics = "Частота процессора и тд и тп" });
            
            //context.Products.Add(new Product() { Id = 3, Name = "Product 3", Price = 30 });
            //context.Products.Add(new Product() { Id = 4, Name = "Product 4", Price = 40 });

            base.Seed(context);
        }
    }
}