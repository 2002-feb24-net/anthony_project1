using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BalloonParty.Core.Interfaces;
using BalloonParty.DataAccess.SQLData;
using BalloonParty.Core.Models;
using System.Collections.Generic;


namespace BalloonParty.DataAccess.Repositories
{
    public class CustomerRepo : ICustomers
    {

        private BalloonPartyContext _context;
        public void CustomersRepository()
        {
            _context = new BalloonPartyContext();
        }

        public void CustomersRepository(BalloonPartyContext context)
        {
            _context = context;
        }

        // public IEnumerable<Customers> GetCustomers(string EmailAddress)
        // {
        //     return _context.Customer.ToList();
        // }

        public Core.Models.Customer GetCustomersByID(string EmailAddress)
        {
            return _context.Customer.Find(EmailAddress);
        }

        public void AddCustomer (BalloonParty.Core.Models.Customer customer)
        {
            BalloonParty.DataAccess.SQLData.Customer entity = Mapper.MapCustomer(customer);
            _context.Add(entity);
        }
    }
}