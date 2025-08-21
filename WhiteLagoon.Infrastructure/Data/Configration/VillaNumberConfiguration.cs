using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data.Configration
{
    public class VillaNumberConfiguration : IEntityTypeConfiguration<VillaNumber>
    {
        public void Configure(EntityTypeBuilder<VillaNumber> builder)
        {
            builder.HasData(new VillaNumber
            {
                Villa_Number = 101,
                SpecialDetails = "Beachside, ground floor",
                VillaId = 1
            },
        new VillaNumber
        {
            Villa_Number = 102,
            SpecialDetails = "Top floor, mountain view",
            VillaId = 2
        },
        new VillaNumber
        {
            Villa_Number = 201,
            SpecialDetails = "Penthouse in city center",
            VillaId = 3
        },
        new VillaNumber
        {
            Villa_Number = 301,
            SpecialDetails = "Desert escape with pool",
            VillaId = 4
        },
        new VillaNumber
        {
            Villa_Number = 401,
            SpecialDetails = "Lake view private suite",
            VillaId = 5
        });
        }
    }
}
