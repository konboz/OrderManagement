using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product()
        {
        }
       public override string ToString()
        {
            return $"{ProductId}:{ProductName}:{Price}:{Category.ToString()}";
        }
    }
}
