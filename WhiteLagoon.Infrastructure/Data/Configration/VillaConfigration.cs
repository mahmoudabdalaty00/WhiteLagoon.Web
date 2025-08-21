using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data.Configration
{
    public class VillaConfigration : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> builder)
        {
            builder.HasData(new Villa
            {
                Id = 1,
                Name = "Luxury Beach Villa",
                Description = "A villa with a stunning beach view.",
                Price = 500.00,
                Sqft = 1200,
                Occupancy = 4,
                ImageUrl = "https://www.bing.com/ck/a?!&&p=43cdb6ccfa1f7379d23e4a02b9154bf2e7e9c51281e99b698f5cf6ead584a3f5JmltdHM9MTc1NTY0ODAwMA&ptn=3&ver=2&hsh=4&fclid=2c66945a-1217-6b5c-2159-84b9136b6a71&u=a1L2ltYWdlcy9zZWFyY2g_cT12aWxsYStpbWFnZXMmaWQ9QjkzRkZGNjUwRDQxMDU4QTAzN0U4QUVEQTc5MkVENUJGQzZBNzNCOCZGT1JNPUlBQ0ZJUg&ntb=1",
                CreatedDate = new DateTime(2025, 08, 20)
            },
            new Villa
            {
                Id = 2,
                Name = "Mountain Retreat",
                Description = "Quiet villa in the mountains.",
                Price = 350.00,
                Sqft = 950,
                Occupancy = 3,
                ImageUrl = "https://www.bing.com/ck/a?!&&p=43cdb6ccfa1f7379d23e4a02b9154bf2e7e9c51281e99b698f5cf6ead584a3f5JmltdHM9MTc1NTY0ODAwMA&ptn=3&ver=2&hsh=4&fclid=2c66945a-1217-6b5c-2159-84b9136b6a71&u=a1L2ltYWdlcy9zZWFyY2g_cT12aWxsYStpbWFnZXMmaWQ9QjkzRkZGNjUwRDQxMDU4QTAzN0U4QUVEQTc5MkVENUJGQzZBNzNCOCZGT1JNPUlBQ0ZJUg&ntb=1",
                CreatedDate = new DateTime(2025, 08, 20)
            },
            new Villa
            {
                Id = 3,
                Name = "City Center Villa",
                Description = "Located in the heart of the city.",
                Price = 600.00,
                Sqft = 1500,
                Occupancy = 5,
                ImageUrl = "https://s-media-cache-ak0.pinimg.com/originals/22/80/13/228013d23c2ca5ed80a74c6bfd6da3e2.jpg",
                CreatedDate = new DateTime(2025, 08, 20)
            },
            new Villa
            {
                Id = 4,
                Name = "Desert Escape",
                Description = "Experience the desert lifestyle.",
                Price = 400.00,
                Sqft = 1100,
                Occupancy = 4,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/07/0b/fa/c1/diana-hotel.jpg?w=900&h=500&s=1",
                CreatedDate = new DateTime(2025, 08, 20)
            },
            new Villa
            {
                Id = 5,
                Name = "Lake House Villa",
                Description = "Villa with a relaxing lake view.",
                Price = 450.00,
                Sqft = 1300,
                Occupancy = 4,
                ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/11/3b/a0/70/diana-hotel.jpg?w=300&h=200&s=1",
                CreatedDate = new DateTime(2025, 08, 20)
            });
        }
    }
}
