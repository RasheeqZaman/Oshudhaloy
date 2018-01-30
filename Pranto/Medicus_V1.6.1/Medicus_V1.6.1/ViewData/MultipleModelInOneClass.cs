using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.ViewData
{
    public class MultipleModelInOneClass
    {
        public Medicine medicine { get; set; }
        public Customers customers { get; set; }
        public Admin admin { get; set; }
        public Supplier supplier { get; set; }
    }
}