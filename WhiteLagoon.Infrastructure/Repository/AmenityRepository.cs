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
            var amenty = _appDbContext.Amenities.Find(amenity.Id);
            if (amenty == null)
            {
                throw new KeyNotFoundException($"Amenity with Id {amenity.Id} not found.");
            }
            if (amenty != null)
            {
                amenty.Id = amenity.Id;
                amenty.Description = amenity.Description;
                amenty.Name = amenity.Name;
                amenty.VillaId = amenity.VillaId;
                amenty.DisplayOrder = amenity.DisplayOrder;
                amenty.UpdatedDate = DateTime.UtcNow;
             }
            
        }
    }
}
