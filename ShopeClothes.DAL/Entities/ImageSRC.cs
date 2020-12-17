namespace ShenStore.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImageSRC")]
    public partial class ImageSRC
    {
        public ImageSRC()
        {
            GoodsImage = new HashSet<GoodsImage>();
        }

        public int Id { get; set; }

        [Required]
        public byte[] Value { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public virtual ICollection<GoodsImage> GoodsImage { get; set; }
    }
}
