namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long id { get; set; }

        [StringLength(10)]
        [Display(Name ="Mã sản phẩm")]
        public string code { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên sản phẩm")]
        public string name { get; set; }

        [StringLength(500)]
        [Display(Name = "Mô tả")]
        public string description { get; set; }

        [StringLength(250)]
        [Display(Name = "Link ảnh")]
        public string images { get; set; }

        [Column(TypeName = "xml")]
        public string moreImages { get; set; }

        [Display(Name = "Giá KM")]
        public decimal? promotionPrice { get; set; }

        [Display(Name = "Đã bao gồm VAT")]
        public bool includedVAT { get; set; }

        [Display(Name = "Giá")]
        public decimal? price { get; set; }

        [Display(Name = "Số lượng")]
        public int? quantity { get; set; }

        [Display(Name = "Loại sản phẩm")]
        public long? categoryID { get; set; }

        [StringLength(250)]
        [Display(Name = "Meta-title")]
        public string metaTitle { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Thông tin sản phẩm")]
        public string detail { get; set; }

        [Display(Name = "Bảo hành")]
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

        [Display(Name = "Trạng thái")]
        public bool status { get; set; }

        public DateTime? topHot { get; set; }

        public int? viewCount { get; set; }
    }
}
