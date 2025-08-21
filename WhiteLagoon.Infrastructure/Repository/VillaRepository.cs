using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class VillaRepository :Repository<Villa> , IVillaRepository
    {
        private readonly AppDbContext _db;

        public VillaRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Villa villa)
        {
            _db.Villas.Update(villa);
        }
    }

}
