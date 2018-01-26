using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.Models
{
    public class CustomerCart
    {
        [Key]
        public int CustomerOrderId { get; set; }
        public int CCartId { get; set; }
        [ForeignKey("CustomerOrderId")]
        public CustomerOrder customerOrder { get; set; }
    }
}