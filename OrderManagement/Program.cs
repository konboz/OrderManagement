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
            //    "JDoe@gmail.com",
            //    "John",
            //    "Trikala",
            //    new DateTime(1958, 4, 17));

            //var c2 = service.Register(
            //    "JnDoe@gmail.com",
            //    "Jane",
            //    "Athens",
            //    new DateTime(1995, 3, 27));

            ////Validating correct entry
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

            //service.Register(
            //    "koukos@gmail.com",
            //    "Nikos",
            //    "Athens",
            //    new DateTime(1965, 6, 22));

            //service.Register(
            //    "Korobos@gmail.com",
            //    "George",
            //    "Athens",
            //    new DateTime(1992, 1, 1));

            ////////////////////////////////////////////////

            ////Updating Customer////

            //service.Update(
            //    "kotsos@gmail.com",
            //    "Konstantinos",
            //    "Thessaloniki",
            //    new DateTime(1991, 2, 18));
            ////////////////////////////////////////////////

            ////Deleting Customer////

            //service.Delete("kavourdoukos@gmail.com");
            /////////////////////////////////////////////////

            ////Adding basket to customer////

            //var basket = new Basket();
            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "Zara",
            //    Category = ProductCategory.Jeans,
            //    Price = 25.45m
            //});

            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "Dainese",
            //    Category = ProductCategory.Jackets,
            //    Price = 99.99m
            //});

            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "TCX",
            //    Category = ProductCategory.Shoes,
            //    Price = 125.58m
            //});

            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "Polo",
            //    Category = ProductCategory.Bags,
            //    Price = 35.45m
            //});

            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "Benetton",
            //    Category = ProductCategory.Shirts,
            //    Price = 29.99m
            //});

            //basket.Cart.Add(new Product()
            //{
            //    ProductName = "Levis",
            //    Category = ProductCategory.Jeans,
            //    Price = 105.58m
            //});
            //
            //service.AddBasket("kotsos@gmail.com", basket);
            //////////////////////////////////////////////

            ////Deleting basket////

            //service.DeleteBasket("kotsos@gmail.com", 2);
            /////////////////////////////////////////////

            ////Recent customers////

            //var customers = service.GetRecentCustomers();

            //foreach (Customer t in customers)
            //{
            //    Console.WriteLine(t);
            //}


            Console.ReadLine();
        }
    }
}
