using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public List<Product> Cart { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }

        public Basket()
        {
            Cart = new List<Product>();
        }
    }
}
