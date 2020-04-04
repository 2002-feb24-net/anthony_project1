using System;
using System.Linq;
using BalloonParty.Core.Models;

namespace BalloonParty.DataAccess
{
    public class Mapper
    {

        public static BalloonParty.Core.Models.Customer MapCustomer(BalloonParty.DataAccess.SQLData.Customer customer)
        {
            return new BalloonParty.DataAccess.SQLData.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                EmailAddress = customer.EmailAddress,
                CustomerPw = customer.CustomerPw,
                Address = customer.Address,
                City = customer.City,
                State = customer.State,
                ZipCode = customer.ZipCode,
            };
        }
    }
}