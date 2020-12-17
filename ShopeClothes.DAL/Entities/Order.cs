namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            OrderList = new HashSet<OrderList>();
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        [StringLength(500)]
        public string DeliveryAddress { get; set; }

        public virtual Status Status { get; set; }

        public virtual ICollection<OrderList> OrderList { get; set; }
    }
}
