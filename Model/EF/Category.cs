namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public long id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string metaTitle { get; set; }

        public long? parentID { get; set; }

        public int? displayOrder { get; set; }

        [StringLength(250)]
        public string seoTitle { get; set; }

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

        public bool? showOnHome { get; set; }
    }
}
