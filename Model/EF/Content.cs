namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(250)]
        public string images { get; set; }

        public long? categoryID { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        public int warranty { get; set; }

        public DateTime? createdDate { get; set; }

        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        [StringLength(50)]
        public string metaKeyWords { get; set; }

        [StringLength(250)]
        public string metaDescriptions { get; set; }

        public bool? status { get; set; }

        public DateTime? topHot { get; set; }

        public int? viewCount { get; set; }

        [StringLength(500)]
        public string tags { get; set; }
    }
}
