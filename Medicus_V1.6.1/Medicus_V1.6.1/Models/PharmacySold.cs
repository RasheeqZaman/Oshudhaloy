using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.Models
{
    public class PharmacySold
    {

        [Key]
        public int CustomerCartId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SoldDate { get; set; }

        [ForeignKey("CustomerCartId")]
        public CustomerCart customerCart { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }
    }
}