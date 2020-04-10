using System;
using System.Collections.Generic;
using System.Text;

namespace BalloonParty.Core.Models
{
    public class Store
    {
        public string _StoreName { get; set; }
        public string _StoreUsername { get; set; }
        public string _StorePw { get; set; }
        public string _Address { get; set; }
        public string _City { get; set; }
        public string _State { get; set; }
        public int _ZipCode { get; set; }
        public int _StoreId { get; set; }


        public string  StoreName
        {
            get => _StoreName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _StoreName = value;
            }
        }

        public string  StoreUsername
        {
            get => _StoreUsername;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _StoreUsername = value;
            }
        }

        public string  StorePw
        {
            get => _StorePw;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _StorePw = value;
            }
        }

        public string  Address
        {
            get => _Address;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _Address = value;
            }
        }

        public string  City
        {
            get => _City;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _City = value;
            }
        }

        public string  State
        {
            get => _State;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _State = value;
            }
        }

        public int  ZipCode
        {
            get => _ZipCode;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _ZipCode = value;
            }
        }

        public int StoreID{get; set;}
    }
}