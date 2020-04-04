using System;
using System.Collections.Generic;

namespace BalloonParty.DataAccess.SQLData
{
    public partial class Products
    {
        public Products()
        {
            ProductsPurchased = new HashSet<ProductsPurchased>();
            StoreInventory = new HashSet<StoreInventory>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public virtual ICollection<ProductsPurchased> ProductsPurchased { get; set; }
        public virtual ICollection<StoreInventory> StoreInventory { get; set; }
    }
}
