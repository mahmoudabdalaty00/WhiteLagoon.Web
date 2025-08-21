using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly AppDbContext _appDbContext;
        public AmenityRepository(AppDbContext db) : base(db)
        {
            _appDbContext = db;
        }

        public void Update(Amenity amenity)
        {
           _appDbContext.Amenities.Update(amenity);
        }
    }
}
