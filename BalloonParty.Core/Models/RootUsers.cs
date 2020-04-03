using System;
using System.Collections.Generic;
using System.Text;

namespace BalloonParty.Core.Models
{
    public class RootUsers
    {
        private string _RootName { get; set; }
        private string _RootPw { get; set; }

        public string RootName
        {
            get => _RootName;
            set
            {
                if (value.Length == 0)
                {
                    throw new System.Exception("Roon Name Cannot Be Empty", nameof(value));
                }
                _RootName = value;
            }
        }

        public string RootPW
        {
            get => _RootPw;
            set 
            {
                if (value.Length == 0)
                {
                    throw new System.Exception("Root Password Cannot Be Empty", nameof(value));
                }
                _RootPw = value;
            }
            
        }
    }
}