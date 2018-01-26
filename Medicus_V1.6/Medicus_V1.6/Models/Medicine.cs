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
        public string Name { get; set; }
        public string GenericName { get; set; }
        public int SupplierPrice { get; set; }
        public int SellPrice { get; set; }
        public string Catagory { get; set; }
        public string Details { get; set; }
    }
}