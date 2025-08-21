using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            VillaRepository = new VillaRepository(_db);
            AmenityRepository = new AmenityRepository(_db);
        }

        public IVillaRepository VillaRepository { get; private set; }
        public IAmenityRepository AmenityRepository { get; private set; }
       

        public void SaveChanges()
        {
          _db.SaveChanges();
        }
    }
}
