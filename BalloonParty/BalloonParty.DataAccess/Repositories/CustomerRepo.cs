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

        public CustomerRepo(BalloonPartyContext context)
        {
            _context = context;
        }

        // Gets the customer by their ID(email address)
        public BalloonParty.Core.Models.Customer GetCustomersByID(string EmailAddress)
        {

            var customer = _context.Customer.SingleOrDefault(p => p.EmailAddress == EmailAddress);

            if(customer == null)
            {
                return null;
            }
            return BalloonParty.DataAccess.Mapper.MapCustomerByID(customer);
        }

        public List<BalloonParty.Core.Models.Customer> GetAllCustomers()
        {
            var customers = _context.Customer.ToList();

            return customers.Select(Mapper.MapCORECustomer).ToList();
        }

        public void AddNewCustomer(BalloonParty.Core.Models.Customer customer)
        {
            var newCustomer = Mapper.MapSQLCustomer(customer);
            _context.Add(newCustomer);
            Save();
        }

        /// <summary>
        /// Takes Customer information annd updates the database with the new information
        /// </summary>
        /// <param name="customer"></param>
        public void UpdateCustomer(Core.Models.Customer customer)
        {
            DataAccess.SQLData.Customer currentCustomer = _context.Customer.Find(customer.EmailAddress);
            DataAccess.SQLData.Customer updatedCustomer = Mapper.MapSQLCustomer(customer);
            _context.Entry(currentCustomer).CurrentValues.SetValues(updatedCustomer);
            Save();
        }


        public void Save()
        {
            _context.SaveChanges();
        }

    }
}