using System;
using System.Collections.Generic;

namespace BalloonParty.Infra.Data
{
    public partial class Store
    {
        public Store()
        {
            ProductsPurchased = new HashSet<ProductsPurchased>();
            StoreInventory = new HashSet<StoreInventory>();
        }

        public string StoreName { get; set; }
        public string StoreUsername { get; set; }
        public string StorePw { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int StoreId { get; set; }

        public virtual ICollection<ProductsPurchased> ProductsPurchased { get; set; }
        public virtual ICollection<StoreInventory> StoreInventory { get; set; }
    }
}
