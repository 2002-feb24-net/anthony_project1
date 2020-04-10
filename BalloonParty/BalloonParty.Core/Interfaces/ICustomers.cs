using System;
using System.Collections.Generic;
using System.Text;

using BalloonParty.Core.Models;

namespace BalloonParty.Core.Interfaces
{
    public interface ICustomers
    {
        // IEnumerable<Customers> GetCustomers(string EmailAddress);

        Customer GetCustomersByID(string EmailAddress);
        // void AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        void AddNewCustomer(Customer customer);

        void UpdateCustomer(Customer customer);
        // void Save();
    }
}