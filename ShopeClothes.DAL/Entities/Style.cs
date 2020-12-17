namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Style")]
    public partial class Style
    {
        public Style()
        {
            Goods = new HashSet<Goods>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public virtual ICollection<Goods> Goods { get; set; }
    }
}
