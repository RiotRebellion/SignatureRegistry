using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class Support : Entity
    {
        [Required]
        public virtual string ActivationCode { get; set; }

        [Required]
        public virtual DateTime ExpirationDate { get; set; }

        public virtual List<Licence> Licences { get; set; }

        public virtual string? PhoneNumber { get; set; }

        public virtual string? Email { get; set; }
    }
}