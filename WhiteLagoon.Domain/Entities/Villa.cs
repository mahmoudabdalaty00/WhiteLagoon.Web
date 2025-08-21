using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WhiteLagoon.Domain.Entities
{
    public class Villa : BaseEntities
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        [DisplayName("Price per Night")]
        public double Price { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }

        [DisplayName("Image Url")]
        public string? ImageUrl { get; set; }

    }
}
