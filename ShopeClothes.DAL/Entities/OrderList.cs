namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderList")]
    public partial class OrderList
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public virtual Goods Goods { get; set; }

        public virtual Order Order { get; set; }
    }
}
