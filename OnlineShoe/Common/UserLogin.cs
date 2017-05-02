using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoe.Common
{
    [Serializable]
    public class UserLogin
    {
        public long userID { get; set; }
        public string username { get; set; }
    }
}