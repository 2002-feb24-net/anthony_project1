using System;
using System.Collections.Generic;
using System.Text;


namespace BalloonParty.Core.Models
{
    public class StoreInventory
    {
        private int _StoreId { get; set; }
        private int _ProductId { get; set; }
        private string _ProductName { get; set; }
        private int _ProductCount { get; set; }
        private int _SinventoryId { get; set; }


        public int  StoreId
        {
            get => _StoreId;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _StoreId = value;
            }
        }

        public int  ProductId
        {
            get => _ProductId;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _ProductId = value;
            }
        }

        public string  ProductName
        {
            get => _ProductName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _ProductName = value;
            }
        }

        public int  ProductCount
        {
            get => _ProductCount;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _ProductCount = value;
            }
        }

        public int SinventoryId {get; set;}
    }
}