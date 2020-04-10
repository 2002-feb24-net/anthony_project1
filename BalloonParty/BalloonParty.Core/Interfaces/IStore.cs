using System;
using System.Collections.Generic;
using System.Text;
using BalloonParty.Core.Models;


namespace BalloonParty.Core.Interfaces
{
    public interface IStore
    {

        List<BalloonParty.Core.Models.StoreInventory> GetStoreInvetoryByID(int id);
        BalloonParty.Core.Models.Store GetStoreByID(int id);
        List<BalloonParty.Core.Models.Store> GetAllStores();
    }
}