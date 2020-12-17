using ShenStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopeClothes.DAL.EF
{
    public class ShopClothesDB : DbContext
    {
        public ShopClothesDB()
            : base("name=ShopClothes")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Composition> Composition { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<GoodsComposition> GoodsComposition { get; set; }
        public virtual DbSet<GoodsImage> GoodsImage { get; set; }
        public virtual DbSet<ImageSRC> ImageSRC { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderList> OrderList { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Style> Style { get; set; }
        public virtual DbSet<GoodsSize> GoodsSize { get; set; }

    }
}
