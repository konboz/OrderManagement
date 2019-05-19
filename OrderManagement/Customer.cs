using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace OrderManagement
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }  //Basket history
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Customer(string email, string name, string address, DateTime birthDate)
        {
            Name = name;
            Email = email;
            Address = address;
            BirthDate = birthDate;
            Baskets = new List<Basket>();
            RegistrationDate = DateTime.Today;
        }

        public override string ToString()
        {
            return $"Name: {Name}, email: {Email}, address: {Address}" +
                $", date of birth: {BirthDate}, registration date: {RegistrationDate}";
        }
    }
}
