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
    public class Software : Entity
    {
        [Required]
        public virtual string Name { get; set; }

        public virtual string Version { get; set; }

        public virtual SoftwareType SoftwareType { get; set; }

        public virtual List<Licence> Licences { get; set;}

        public virtual Destribution? Destribution { get; set; }
    }
}
