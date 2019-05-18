using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    public interface ICustomerService
    {
        Customer Register(string email, string name, string address, DateTime birthDate);
        bool Update(string email, string name, string address, DateTime birthDate);
        bool Delete(string email);
        bool AddBasket(string email, Basket basket);
        bool DeleteBasket(string email, int basketId);
        List<Customer> GetRecentCustomers();
    }
}
