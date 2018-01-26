using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GenericName { get; set; }
        [Required]
        public int SupplierPrice { get; set; }
        [Required]
        public int SellPrice { get; set; }
        [Required]
        public string Catagory { get; set; }
        public string Details { get; set; }
    }
}