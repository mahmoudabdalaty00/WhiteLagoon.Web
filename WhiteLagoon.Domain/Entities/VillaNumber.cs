using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhiteLagoon.Domain.Entities
{
    public class VillaNumber
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Villa_Number { get; set; }


        public string SpecialDetails { get; set; }


        public int VillaId { get; set; }
        [ForeignKey(nameof(VillaId))]
        public Villa Villa { get; set; }
    }
}
