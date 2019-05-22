using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public ProductCategory Category { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }

        //public Product()
        //{
        //}
        public override string ToString()
        {
            return $"{ProductId}:{ProductName}:{Price}:{Category.ToString()}";
        }
    }
}
