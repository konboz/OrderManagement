using System;


namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new CustomerService();

            ////Registering Customers////

            //var c1 = service.Register(
            //   "papadopoulos@gmail.com",
            //   "Manolis",
            //   "Athens",
            //   new DateTime(1995, 6, 22));

            //var c2 = service.Register(
            //    "Nikolaou@gmail.com",
            //    "Nikos",
            //    "Korinthos",
            //    new DateTime(2002, 1, 1));

            //Validating successful entry
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);

            //service.Register(
            //    "Matsablokou@gmail.com",
            //    "Aggeliki",
            //    "Korinthos",
            //    new DateTime(1988, 7, 12));

            //service.Register(
            //    "kotsos@gmail.com",
            //    "Kostas",
            //    "Athens",
            //    new DateTime(1988, 9, 14));
            ////////////////////////////////////////////////

            ////Updating Customer////

            //service.Update(
            //    "kotsos@gmail.com",
            //    "Konstantinos",
            //    "Thessaloniki",
            //    new DateTime(1991, 2, 18));
            ////////////////////////////////////////////////

            ////Deleting Customer////

            //service.Delete("JnDoe@gmail.com");
            /////////////////////////////////////////////////

            ////Adding basket to customer////

            //var basket = new Basket();

            //basket.BasketProducts.Add(new BasketProduct()
            //{
            //    Basket = basket,
            //    Product = new Product()
            //    {
            //        ProductName = "Benetton",
            //        Category = ProductCategory.Shirts,
            //        Price = 35.58m
            //    }
            //});

            //basket.BasketProducts.Add(new BasketProduct()
            //{
            //    Basket = basket,
            //    Product = new Product()
            //    {
            //        ProductName = "Diesel",
            //        Category = ProductCategory.Jeans,
            //        Price = 89.99m
            //    }
            //});

            //basket.BasketProducts.Add(new BasketProduct()
            //{
            //    Basket = basket,
            //    Product = new Product()
            //    {
            //        ProductName = "Nautica",
            //        Category = ProductCategory.Jackets,
            //        Price = 29.99m
            //    }
            //});

            //basket.BasketProducts.Add(new BasketProduct()
            //{
            //    Basket = basket,
            //    Product = new Product()
            //    {
            //        ProductName = "Jack&Jones",
            //        Category = ProductCategory.Jeans,
            //        Price = 55.45m
            //    }
            //});

            //basket.BasketProducts.Add(new BasketProduct()
            //{
            //    Basket = basket,
            //    Product = new Product()
            //    {
            //        ProductName = "Revit",
            //        Category = ProductCategory.Shoes,
            //        Price = 145.58m
            //    }
            //});

            //service.AddBasket("JnDoe@gmail.com", basket);
            //////////////////////////////////////////////

            ////Deleting basket////

            //service.DeleteBasket("JnDoe@gmail.com", 2);
            /////////////////////////////////////////////

            ////Recent customers////

            //var recentCustomers = service.GetRecentCustomers();

            //foreach (Customer t in recentCustomers)
            //{
            //    Console.WriteLine(t);
            //}


            Console.ReadLine();
        }
    }
}
