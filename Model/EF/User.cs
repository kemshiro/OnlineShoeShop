namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long id { get; set; }

        [StringLength(50)]
        [Display(Name ="Tài Khoản")]
        public string username { get; set; }

        [StringLength(32)]
        [Display(Name = "Mật Khẩu")]
        public string password { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ Tên")]
        public string name { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [StringLength(50)]
        [Display(Name = "Điện Thoại")]
        public string phone { get; set; }

        public DateTime? createdDate { get; set; }

        [StringLength(50)]
        public string createdBy { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string modifiedBy { get; set; }

        [Display(Name = "Trạng Thái")]
        public bool status { get; set; }
    }
}
