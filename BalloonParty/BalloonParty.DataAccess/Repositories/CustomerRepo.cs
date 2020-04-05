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


        public void CustomersRepository()
        {
            _context = new BalloonPartyContext();
        }

        public void CustomersRepository(BalloonPartyContext context)
        {
            _context = context;
        }

        // Gets the customer by their ID(email address)
        public Core.Models.Customer GetCustomersByID(string EmailAddress)
        {
            var customer = _context.Customer.Find(EmailAddress);
            if(customer != null)
            {
                return Mapper.MapCustomerByID(customer);
            }
            return null;
        }

        // adds customer to db
        public void AddCustomer (BalloonParty.Core.Models.Customer customer)
        {
            BalloonParty.DataAccess.SQLData.Customer entity = Mapper.MapCustomer(customer);
            _context.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}