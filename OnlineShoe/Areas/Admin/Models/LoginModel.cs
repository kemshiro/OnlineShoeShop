using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoe.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Mời nhập password")]
        public string pass { get; set; }

        public bool rememberMe { get; set; }
    }
}