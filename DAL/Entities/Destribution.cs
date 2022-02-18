using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class Destribution : Entity
    {
        [Required]
        public virtual string Number { get; set; }

        public virtual string? OrgRegNumber { get; set; }

        public virtual Formular? Formular { get; set; }
    }
}