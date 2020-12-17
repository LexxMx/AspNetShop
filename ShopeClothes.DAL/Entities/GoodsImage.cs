namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsImage")]
    public partial class GoodsImage
    {
        public int Id { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual ImageSRC ImageSRC { get; set; }
    }
}
