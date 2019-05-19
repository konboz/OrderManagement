using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    public class CustomerService : ICustomerService
    {
        public Customer Register(string email, string name, string address, DateTime birthDate)
        {
            var customer = new Customer(email, name, address, birthDate);
            return customer;
        }

        public bool Update(string email, string name, string address, DateTime birthDate)
        {
            try
            {
                var context = new OrderManagementDbContext();
                var result = context.Set<Customer>().SingleOrDefault(b => b.Email == email);
                if (result != null)
                {
                    result.Name = name;
                    result.Address = address;
                    result.BirthDate = birthDate;
                    context.SaveChanges();

                    return true;
                }
                else
                {
                    Console.WriteLine("Email wrong or not found"); ;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool Delete(string email) //Deletes customer entry from database
        {
            try
            {
                var context = new OrderManagementDbContext();
                var result = context.Set<Customer>().SingleOrDefault(b => b.Email == email);
                if (result != null)
                {
                    context.Remove(result);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool AddBasket(string email, Basket basket)
        {
            try
            {
                var context = new OrderManagementDbContext();
                var result = context.Set<Customer>()
                    .SingleOrDefault(b => b.Email == email);
                if (result != null)
                {
                    result.Baskets.Add(basket);
                    context.Add(basket);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteBasket(string email, int basketId) //Doesn't delete basket from database
        {
            try
            {
                var context = new OrderManagementDbContext();
                var result = context.Set<Customer>()
                    .SingleOrDefault(c => c.Email == email);
                if (result != null)
                {

                    var result2 = context.Set<Basket>()
                    .SingleOrDefault(b => b.BasketId == basketId);
                    if (result2 != null && result2.Customer.CustomerId == result.CustomerId)
                    {
                        result.Baskets.Remove(result2);
                        context.SaveChanges();
                        //context.Remove(result2); //Throws exception//
                        //context.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Customer> GetRecentCustomers()
        {
            var list = new List<Customer>();
            try
            {
                var context = new OrderManagementDbContext();
                list = context.Set<Customer>()
                    .Where(c => c.RegistrationDate.AddDays(7) >= DateTime.Today)
                    .ToList();

                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return list;
            }
        }

    }
}
