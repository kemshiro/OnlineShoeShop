namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        public DateTime? createdDate { get; set; }

        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        [StringLength(50)]
        public string metaKeyWords { get; set; }

        [Required]
        [StringLength(250)]
        public string metaDescriptions { get; set; }

        public bool? status { get; set; }

        [StringLength(250)]
        public string images { get; set; }
    }
}
