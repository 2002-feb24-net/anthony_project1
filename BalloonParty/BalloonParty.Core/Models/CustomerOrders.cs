using System;
using System.Collections.Generic;
using System.Text;

namespace BalloonParty.Core.Models
{
    public class CustomerOrders
    {
        private string _CustomerEmail { get; set; }
        private DateTime _OrderDate { get; set; }
        private int _FullProductCount { get; set; }
        private decimal _TotalPrice { get; set; }
        private int _CustomerOrderId { get; set; }
        private string _ProductName { get; set; }


        public string  CustomerEmail
        {
            get => _CustomerEmail;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _CustomerEmail = value;
            }
        }

        public DateTime OrderDate {get; set;}
        // {
        //     get => _OrderDate;
        //     set
        //     {
        //         if (value = ?)
        //         {
        //             throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
        //         }
        //         _OrderDate = value;
        //     }
        // }

        public int  FullProductCount
        {
            get => _FullProductCount;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _FullProductCount = value;
            }
        }

        public decimal  TotalPrice
        {
            get => _TotalPrice;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _TotalPrice = value;
            }
        }

        public int CustomerOrderId {get; set;}

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
    }
}