﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trixx_CafeSystem
{
    public class OrderProducts
    {
        [ForeignKey("Order"), Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [ForeignKey("Product"), Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Order  Order { get; set; }
        public virtual Product Product{ get; set; }
        public int Quantity { get; set; }
        public double AmountPrice { get; set; }
    }
}
