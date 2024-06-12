﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    internal class ReceiptDetail : BaseEntity
    {
        [ForeignKey(nameof(Receipt))]
        public int ReceiptId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public decimal DiscountUnitPrice { get; set; }
        decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Receipt Receipt { get; set; }
        public Product Product { get; set; }
    }
}
