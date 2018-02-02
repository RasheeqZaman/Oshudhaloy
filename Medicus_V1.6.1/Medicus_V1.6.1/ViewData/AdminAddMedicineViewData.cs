using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class AdminAddMedicineViewData
    {

        [Required]
        [Display(Name = "Medicine Name")]
        public string medicineName { get; set; }

        [Required]
        [Display(Name = "Supplier Price")]
        public int supplierPrice { get; set; }
        [Required]
        [Display(Name = "Sell Price")]
        public int sellPrice { get; set; }
        [Required]
        [Display(Name = "Generic Name")]
        public string genericName { get; set; }
        [Required]
        [Display(Name = "Category")]
        public string category { get; set; }
        [Required]
        [Display(Name = "Details")]
        public string details { get; set; }


    }
}