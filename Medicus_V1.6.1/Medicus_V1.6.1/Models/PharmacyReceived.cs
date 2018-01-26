using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.Models
{
    public class PharmacyReceived
    {
        [Key]
        public int PharmacyReceivedId { get; set; }
        public int PharmacyId { get; set; }
        public int SupplierId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public String Shelf { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier supplier { get; set; }
        [ForeignKey("PharmacyId")]
        public Pharmacy pharmacy { get; set; }
        [ForeignKey("MedicineId")]
        public Medicine medicine { get; set; }
    }
}