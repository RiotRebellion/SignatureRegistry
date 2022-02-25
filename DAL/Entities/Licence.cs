using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class Licence : Entity
    {
        [Required]
        public virtual string LicenceNumber { get; set; }

        [Required]
        public virtual DateTime AcquisitionDate { get; set; }

        public virtual DateTime? ExpirationDate { get; set; }

        [Required]
        public virtual int SoftwareId { get; set; }
        public virtual Software Software { get; set; }

        [Required]
        public virtual int ComputerId { get; set; }
        public virtual Computer Computer { get; set; }

        [Required]
        public virtual int ContractId { get; set; }
        public virtual Contract Contract { get; set; }

        public virtual int SupportID { get; set; }
        public virtual Support? Support { get; set; }

    }
}