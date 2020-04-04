using System;
using System.Collections.Generic;

namespace BalloonParty.DataAccess.SQLData
{
    public partial class ProductsPurchased
    {
        public int PurchasedProductId { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int StoreId { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual Customer CustomerEmailNavigation { get; set; }
        public virtual Products Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
