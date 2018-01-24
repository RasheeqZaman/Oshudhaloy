using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Admin
    {

        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PharmacyId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Pharmacy Pharmacy { get; set; }
    }
}