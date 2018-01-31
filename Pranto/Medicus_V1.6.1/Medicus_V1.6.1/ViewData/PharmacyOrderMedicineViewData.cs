using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class PharmacyOrderMedicineViewData
    {
        public List<Medicine> medicineList { get; set; }
        public List<Supplier> supplierList { get; set; }

        [Required]
        [Display(Name = "Medicine Name")]
        public int medicineId { get; set; }

        [Required]
        [Display(Name = "Supplier Name")]
        public int supplierId { get; set; }


        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }

        [Required]
        [Display(Name = "Expire Date")]
        public DateTime expiredDate { get; set; }


        [Required]
        [Display(Name = "Shelf")]
        public string shelf { get; set; }






    }
}