namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int id { get; set; }

        [StringLength(50)]
        public string text { get; set; }

        [StringLength(50)]
        public string link { get; set; }

        public int? displayOrder { get; set; }

        [StringLength(50)]
        public string target { get; set; }

        public bool? status { get; set; }

        public int? typeID { get; set; }
    }
}
