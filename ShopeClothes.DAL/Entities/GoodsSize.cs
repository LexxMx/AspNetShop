namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsSize")]
    public partial class GoodsSize
    {
        public int Id { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Size Size { get; set; }
    }
}
