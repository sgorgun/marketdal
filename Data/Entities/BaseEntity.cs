using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    internal class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
