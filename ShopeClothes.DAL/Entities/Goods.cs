namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        public Goods()
        {
            GoodsComposition = new HashSet<GoodsComposition>();
            GoodsImage = new HashSet<GoodsImage>();
            GoodsSize = new HashSet<GoodsSize>();
            OrderList = new HashSet<OrderList>();
        }

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        public double Price { get; set; }

        public int? Quantity { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCode { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual Color Color { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        public virtual Style Style { get; set; }

        public virtual ICollection<GoodsComposition> GoodsComposition { get; set; }

        public virtual ICollection<GoodsImage> GoodsImage { get; set; }

        public virtual ICollection<GoodsSize> GoodsSize { get; set; }

        public virtual ICollection<OrderList> OrderList { get; set; }
    }
}
