using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class MultipleModelInOneClass
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public int SupplierPrice { get; set; }
        public int SellPrice { get; set; }
        public string Catagory { get; set; }
        public string Details { get; set; }

        public int PharmacyReceivedId { get; set; }
        public int PharmacyId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public String Shelf { get; set; }


        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


    }
}