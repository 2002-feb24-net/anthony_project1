using System;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BalloonParty.Core.Interfaces;
using BalloonParty.DataAccess.SQLData;
using BalloonParty.Core.Models;
using System.Collections.Generic;

namespace BalloonParty.DataAccess.Repositories
{
    public class StoreRepo : IStore
    {
        private BalloonPartyContext _context;

        public StoreRepo(BalloonPartyContext context)
        {
            _context = context;
        }

        public BalloonParty.Core.Models.Store GetStoreByID(int id)
        {
            var store = _context.Store.SingleOrDefault(i => i.StoreId == id);
            return BalloonParty.DataAccess.Mapper.MapStoreByID(store);

        }

        public List<BalloonParty.Core.Models.Store> GetAllStores()
        {
            var stores = _context.Store.ToList();
            
            return stores.Select(Mapper.MapStoreByID).ToList();
        }

        public List<BalloonParty.Core.Models.StoreInventory> GetStoreInvetoryByID(int id)
        {
            var storeInventory = _context.StoreInventory.Where(si => si.StoreId == id).ToList();
            return storeInventory.Select(Mapper.MapInventoryByID).ToList();

        }
    }
}