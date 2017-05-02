namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfig")]
    public partial class SystemConfig
    {
        [StringLength(50)]
        public string id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(50)]
        public string value { get; set; }

        public bool? status { get; set; }
    }
}
