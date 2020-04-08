using System;
using System.Linq;
using BalloonParty.Core.Models;
using System.Collections.Generic;
using BalloonParty.DataAccess.SQLData;

namespace BalloonParty.DataAccess
{
    public class Mapper
    {


        public static BalloonParty.DataAccess.SQLData.Customer MapCustomer(BalloonParty.Core.Models.Customer customer)
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

        public static BalloonParty.Core.Models.Customer MapCustomerByID(BalloonParty.DataAccess.SQLData.Customer customer)
        {
            return new BalloonParty.Core.Models.Customer
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