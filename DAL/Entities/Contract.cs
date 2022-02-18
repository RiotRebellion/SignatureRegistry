using DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DAL.Entities
{
    public class Contract : Entity
    {
        [Required]
        public virtual string ContractNumber { get; set; }

        [Required]
        public virtual DateTime Date { get; set; }
    }
}