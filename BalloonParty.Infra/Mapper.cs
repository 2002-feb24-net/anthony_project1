using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalloonParty.Infra
{
    public class Mapper
    {
        public static Core.Models.Product MapProduct(Model.Product product)
        {
            return new Core.Models.Product
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                CustomerOrders = product.CustomerOrders.Select(MapCustomerOrders).ToList(),
                StoreInventory = product.StoreInventory.Select(MapStoreInventory).ToList(),
            };
        }
    }
}