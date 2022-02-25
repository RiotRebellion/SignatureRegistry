using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace DAL.Entities
{
    public class Employee : Entity
    {
        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string LastName { get; set; }

        [Required]
        public virtual string Patronymic { get; set; }

        [Required]
        public virtual string Duty { get; set; }

        [Required]
        public virtual int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
