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
        public BalloonParty.DataAccess.SQLData.Customer GetCustomersByID(string EmailAddress)
        {

            var customer = _context.Customer.Find(EmailAddress);

            if(customer == null)
            {
                return null;
            }
            return customer;
        }

        // adds customer to db
        // public void AddCustomer (BalloonParty.Core.Models.Customer customer)
        // {
        //     BalloonParty.DataAccess.SQLData.Customer entity = Mapper.MapCustomer(customer);
        //     _context.Add(entity);
        // }

        // public static List<DataAccess.SQLData.Customer> GetCustomers()
        // {
        //     BalloonPartyContext _context = new BalloonPartyContext();

        //     var customers = _context.Customer.ToList();
        //     return customers;
        // }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}