using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
         public IFormFile Image { get; set; }

        [DisplayName("Image Url")]
        public string? ImageUrl { get; set; }


        [ValidateNever]
        public IEnumerable<Amenity> Amenities { get; set; }

    }
}
