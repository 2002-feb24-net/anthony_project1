using System;
using System.Linq;
using BalloonParty.Core.Models;
using System.Collections.Generic;
using BalloonParty.DataAccess.SQLData;

namespace BalloonParty.DataAccess
{
    public class Mapper
    {


        public static BalloonParty.Core.Models.Customer MapCORECustomer(BalloonParty.DataAccess.SQLData.Customer customer)
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

        public static BalloonParty.DataAccess.SQLData.Customer MapSQLCustomer(BalloonParty.Core.Models.Customer customer)
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

        public static BalloonParty.Core.Models.StoreInventory MapInventoryByID(BalloonParty.DataAccess.SQLData.StoreInventory inventory)
        {
            return new BalloonParty.Core.Models.StoreInventory
            {
                ProductName = inventory.ProductName,
                ProductId = inventory.ProductId,
                ProductCount =  inventory.ProductCount,
                SinventoryId = inventory.SinventoryId,
            };
        }

        public static BalloonParty.Core.Models.Store MapStoreByID(BalloonParty.DataAccess.SQLData.Store store)
        {
            return new BalloonParty.Core.Models.Store
            {
                StoreName = store.StoreName,
                StoreUsername = store.StoreUsername,
                StorePw = store.StorePw,
                Address = store.Address,
                City = store.City,
                State = store.State,
                ZipCode = store.ZipCode,
                StoreID = store.StoreId,
            };
        }

        public static BalloonParty.DataAccess.SQLData.CustomerOrders MapCustomerOrderCORE(BalloonParty.Core.Models.CustomerOrders customerOrders)
        {
            return new BalloonParty.DataAccess.SQLData.CustomerOrders
            {
                CustomerEmail = customerOrders.CustomerEmail,
                OrderDate = customerOrders.OrderDate,
                FullProductCount = customerOrders.FullProductCount,
                TotalPrice = customerOrders.TotalPrice,
                CustomerOrderId = customerOrders.CustomerOrderId,
                ProductName = customerOrders.ProductName,
            };
        }
    }
}