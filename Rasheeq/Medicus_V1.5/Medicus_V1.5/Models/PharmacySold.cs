using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class PharmacySold
    {
        [Key]
        public int Customer_OrderId { get; set; }
        public DateTime ReceiveDate { get; set; }

        [ForeignKey("Customer_OrderId")]
        public CustomerOrder customer_order { get; set; }
    }
}