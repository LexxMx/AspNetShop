namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        public Status()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
