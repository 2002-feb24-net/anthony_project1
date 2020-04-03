using BalloonParty.Core.Interfaces;
using BalloonParty.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BalloonParty.Infra.Repositories
{
    public class BalloonPartyRepo : IBalloonPartyRepo
    {
        private readonly BalloonPartyContext _dbContext;

        public BalloonPartyRepo(BalloonPartyContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public void AddNewCustomer(Core.Models.Customers customers)
        {
            Customers entity = Mapper.MapCustomer(customers);
            _dbContext.Add(entity);
        }
    }
}