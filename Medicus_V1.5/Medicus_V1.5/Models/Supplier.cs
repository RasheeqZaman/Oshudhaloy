using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}