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
        Customer AddCustomer(Customer customer);
    }
}