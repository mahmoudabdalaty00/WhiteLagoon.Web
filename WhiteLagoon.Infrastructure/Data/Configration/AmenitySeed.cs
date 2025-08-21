using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data.Configration
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasData(
                 new Amenity
                 {
                     Id = 1,
                     Name = "Private Pool",
                     Description = "Enjoy a relaxing private pool",
                     VillaId = 1
                 },
                      new Amenity
                {
                    Id = 2,
                    Name = "Free WiFi",
                    Description = "High-speed internet included",
                    VillaId = 1
                },
                      new Amenity
                {
                    Id = 3,
                    Name = "Fireplace",
                    Description = "Cozy indoor fireplace",
                    VillaId = 2
                },
                      new Amenity
                {
                    Id = 4,
                    Name = "Hot Tub",
                    Description = "Relaxing outdoor hot tub",
                    VillaId = 2
                }
                );
        }
    }
}
