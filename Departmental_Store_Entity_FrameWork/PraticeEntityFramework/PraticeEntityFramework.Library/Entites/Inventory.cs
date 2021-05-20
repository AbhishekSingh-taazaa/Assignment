﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeEntityFramework.Library.Entites
{
   public class Inventory
    {
        public string  Product_Code { get; set; }

        public string Brand_Name { get; set; }

        public long Product_Quantity { get; set; }

        public bool InStock { get; set; }

        public Product Product { get; set; }

    }
}
