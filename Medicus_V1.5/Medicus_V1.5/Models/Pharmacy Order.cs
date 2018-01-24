using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Pharmacy_Order
    {

        public int Pharmacy_OrderId { get; set; }
        public int AdminId { get; set; }
        public int SupplierId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }


        public Admin admin { get; set; }
        public Supplier supplier { get; set; }
        public Medicine medicine { get; set; }

    }
}