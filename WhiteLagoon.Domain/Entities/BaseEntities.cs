using System.ComponentModel.DataAnnotations;

namespace WhiteLagoon.Domain.Entities
{
    public class BaseEntities
    {
        [Key]
        public int Id { get; set; }
        

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
