﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExam.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplieriD { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public long UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public virtual Category Category { get; set; }

    }
}