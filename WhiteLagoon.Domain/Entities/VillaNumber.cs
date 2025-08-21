using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhiteLagoon.Domain.Entities
{
    public class VillaNumber
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Villa Number")]
        public int Villa_Number { get; set; }


        public string SpecialDetails { get; set; }

        [DisplayName("Villa")]

        public int VillaId { get; set; }
        [ForeignKey(nameof(VillaId))]
        [ValidateNever]
        public Villa Villa { get; set; }
    }
}
