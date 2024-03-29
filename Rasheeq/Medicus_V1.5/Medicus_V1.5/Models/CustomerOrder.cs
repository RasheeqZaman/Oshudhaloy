﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class CustomerOrder
    {
        public int CustomerOrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }


        public Customers customer { get; set; }
        public Employee employee { get; set; }
        public Medicine medicine { get; set; }
    }
}