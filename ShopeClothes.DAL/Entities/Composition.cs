namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Composition")]
    public partial class Composition
    {
        public Composition()
        {
            GoodsComposition = new HashSet<GoodsComposition>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public virtual ICollection<GoodsComposition> GoodsComposition { get; set; }
    }
}
