using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    public class CustomerService : ICustomerService
    {
        public Customer Register(string email, string name, string address, DateTime birthDate)
        {
            if (birthDate.AddYears(18) <= DateTime.Now)
            {
                try
                {

                    var context = new OrderManagementDbContext();
                    context.Add(new Customer(email, name, address, birthDate));
                    context.SaveChanges();

                    var customer = context.Set<Customer>()
                        .Last();
                    return customer;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return new Customer();
                }
            }
            else
            {
                return new Customer();
            }
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
                    Console.WriteLine("Email not found"); ;
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool Delete(string email) //Deactivates customer
        {
            try
            {
                var context = new OrderManagementDbContext();
                var result = context.Set<Customer>().SingleOrDefault(b => b.Email == email);
                if (result != null)
                {
                    result.ActiveStatus = false;
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
                    basket.Customer = result;
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

        public bool DeleteBasket(string email, int basketId) //Deletes basket from customer
        {
            try
            {
                var context = new OrderManagementDbContext();
                var resultC = context.Set<Customer>() //Customer with given email
                    .SingleOrDefault(c => c.Email == email);
                if (resultC != null)
                {
                    var resultB = context.Set<Basket>() //Basket with given basketId that belongs to above customer
                    .SingleOrDefault(b => b.BasketId == basketId);
                    if (resultB != null && resultB.CustomerId == resultC.CustomerId)
                    {
                        context.Remove(resultB);
                        context.SaveChanges();
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
                    .Where(c => c.RegistrationDate.AddDays(7) >= DateTime.Today 
                    && c.ActiveStatus == true)
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
