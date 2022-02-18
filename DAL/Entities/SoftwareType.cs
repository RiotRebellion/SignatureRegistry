using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class SoftwareType : Entity
    {
        [Required]
        public virtual string Name { get; set; }
        public virtual SoftwareLocation SoftwareLocation { get; set; }
    }
}