using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Domain.Entities
{
    public class Amenity :BaseEntities
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int VillaId { get; set; }
        [ForeignKey(nameof(VillaId))]
        [ValidateNever]
        public virtual Villa Villa { get; set; }

        [DisplayName("Displa Order")]
        public int DisplayOrder { get; set; }

    }
}
