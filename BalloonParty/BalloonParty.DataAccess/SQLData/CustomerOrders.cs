﻿using System;
using System.Collections.Generic;

namespace BalloonParty.DataAccess.SQLData
{
    public partial class CustomerOrders
    {
        public string CustomerEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public int FullProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerOrderId { get; set; }
        public string ProductName { get; set; }

        public virtual Customer CustomerEmailNavigation { get; set; }
    }
}
