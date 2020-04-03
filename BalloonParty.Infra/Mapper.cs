using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BalloonParty.Core.Models;

namespace BalloonParty.Infra
{
    public class Mapper
    {
        // public static Core.Models.Product MapProduct(Model.Product product)
        // {
        //     return new Core.Models.Product
        //     {
        //         ProductID = product.ProductID,
        //         ProductName = product.ProductName,
        //         ProductPrice = product.ProductPrice,
        //         CustomerOrders = product.CustomerOrders.Select(MapCustomerOrders).ToList(),
        //         StoreInventory = product.StoreInventory.Select(MapStoreInventory).ToList(),
        //     };
        // }

        public static Core.Models.Customers MapCustomer(Core.Models.Customers customers)
        {
            return new Core.Models.Customers
            {
                FirstNName = customers.FirstName,
                LastName  = customers.LastName,
                EmailAddress = customers.EmailAddress,
                CustomerPW = customers.CustomerPW,
                Address = customers.Address,
                City  = customers.City,
                State = customers.State,
                ZipCode = customers.ZipCode,
            };
        }
    }
}