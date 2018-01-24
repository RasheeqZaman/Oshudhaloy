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
<<<<<<< HEAD
<<<<<<< HEAD
        public string Name { get; set; }
        public string GenericName { get; set; }
        public int SupplierPrice { get; set; }
=======
        [Required]
        public string Name { get; set; }
=======
        [Required]
        public string Name { get; set; }
>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
        [Required]
        public string GenericName { get; set; }
        [Required]
        public int SupplierPrice { get; set; }
        [Required]
<<<<<<< HEAD
>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
=======
>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
        public int SellPrice { get; set; }
        public string Catagory { get; set; }
        public string Details { get; set; }
    }
}