using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class CustomerOrderMedicineViewData
    {
        public List<Medicine> medicineList { get; set; }
        public List<Pharmacy> pharmacyList { get; set; }

        [Required]
        [Display(Name = "Medicine Name")]
        public int medicineId { get; set; }

        [Required]
        [Display(Name = "Pharmacy Name")]
        public int pharmacyId { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
    }
}