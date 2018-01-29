using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.Models
{
    public class Pharmacy
    {

        public int PharmacyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}