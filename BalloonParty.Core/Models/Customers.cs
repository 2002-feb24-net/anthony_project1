using System;
using System.Collections.Generic;
using System.Text;

namespace BalloonParty.Core.Models
{
    public class Customers
    {
        private string _FirstName { get; set; }
        private string _LastName { get; set; }
        private string _EmailAddress { get; set; }
        private string _CustomerPw { get; set; }
        private string _Address { get; set; }
        private string _City { get; set; }
        private string _State { get; set; }
        private int _ZipCode { get; set; }

        public string  FirstName
        {
            get => _FirstName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _FirstName = value;
            }
        }

        public string  LastName
        {
            get => _LastName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _LastName = value;
            }
        }

        public string  EmailAddress
        {
            get => _EmailAddress;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _EmailAddress = value;
            }
        }

        public string  CustomerPw
        {
            get => _CustomerPw;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _CustomerPw = value;
            }
        }

        public string  Address
        {
            get => _Address;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _Address = value;
            }
        }

        public string City
        {
            get => _City;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _City = value;
            }
        }public string  State
        {
            get => _State;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _State = value;
            }
        }

        public int  ZipCode
        {
            get => _ZipCode;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Last Name Must Not Be Empty.", nameof(value));
                }
                _ZipCode = value;
            }
        }

    }
}