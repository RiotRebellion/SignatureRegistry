using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class AccordanceSertificate : Entity
    {
        [Required]
        public virtual string RegNum { get; set; } = null!;

        [Required]
        public virtual int FormularID { get; set; }
        public virtual Formular Formular { get; set; }

        [Required]
        public virtual DateTime AcquisitionDate { get; set; }

        [Required]
        public virtual DateTime ExpirationDate { get; set; }

        public virtual DateTime? ProlongDate { get; set; }
    }
}