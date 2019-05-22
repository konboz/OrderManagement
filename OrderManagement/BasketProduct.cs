using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    public class BasketProduct
    {
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
