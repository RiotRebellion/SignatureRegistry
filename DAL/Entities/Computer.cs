using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace DAL.Entities
{
    public class Computer : Entity
    {
        [Required]
        public virtual string MacAddress { get; set; }

        [Required, MinLength(4), MaxLength(16)]
        public virtual byte[] IpAddress { get; set; }

        [Required]
        public virtual string InvNumber { get; set; }

        public virtual Employee? Employee { get; set; }

        [Required]
        public virtual string Location { get; set; }

        public virtual DateTime? LastAutorization { get; set; }
    }
}
