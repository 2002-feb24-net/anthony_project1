using System;
using System.Collections.Generic;
using System.Text;

namespace BalloonParty.Core.Models
{
    public class Product
    {
        private string _ProductId;
        private string _ProductName;
        private decimal _ProductPrice;

        public int ProductID {get; set;}

        public string  ProductName
        {
            get => _ProductName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name Must Not Be Empty.", nameof(value));
                }
                _ProductName = value;
            }
        }

        public decimal ProductPrice
        {
            get => _ProductPrice;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Value may not be a negitive number.", nameof(value));
                }
            }
        }

        public List<CustomerOrders> CustomerOrders { get; set; } = new List<CustomerOrders>();

        public List<StoreInventory> StoreInventory { get; set; } = new List<StoreInventory>();
    }
}