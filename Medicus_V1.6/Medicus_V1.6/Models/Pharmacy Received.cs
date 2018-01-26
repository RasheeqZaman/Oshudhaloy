using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Pharmacy_Received
    {
        [Key]
        public int Pharmacy_OrderId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime ExpireDate { get; set; }
        [ForeignKey("Pharmacy_OrderId")]
        public Pharmacy_Order pharmacy_order { get; set; }

    }
}