namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsComposition")]
    public partial class GoodsComposition
    {
        public int Id { get; set; }

        public double? Percent { get; set; }

        public virtual Composition Composition { get; set; }

        public virtual Goods Goods { get; set; }
    }
}
