using System;
using System.Text;
using System.Linq;
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

        public void CustomersRepository(BalloonPartyContext context)
        {
            _context = context;
        }

        // Gets the customer by their ID(email address)
        public BalloonParty.Core.Models.Customer GetCustomersByID(string EmailAddress)
        {

            var customer = _context.Customer.First(p => p.EmailAddress == EmailAddress);

            if(customer == null)
            {
                return null;
            }
            return BalloonParty.DataAccess.Mapper.MapCustomerByID(customer);
        }

        public List<BalloonParty.Core.Models.Customer> GetAllCustomers()
        {
            var customers = _context.Customer.ToList();

            return customers.Select(Mapper.MapCustomer).ToList();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}