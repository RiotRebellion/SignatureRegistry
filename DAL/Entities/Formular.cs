using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class Formular : Entity
    {
        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string SerialKey { get; set; }

        public virtual string? OrgRegNumber { get; set; }
        
        public virtual string? ProtectionKey { get; set; }

        public virtual List<AccordanceSertificate> AccordanceSertificates { get; set; }
    }
}