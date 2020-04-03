using System;
using System.Collections.Generic;
using System.Text;
using BalloonParty.Core.Models;

namespace BalloonParty.Core.Interfaces
{
    public class BalloonPartyRepo
    {
        public interface IBalloonPartyRepo
        {
            Customer GetCustomerByID(string EmailAddress);
        }
    }
}