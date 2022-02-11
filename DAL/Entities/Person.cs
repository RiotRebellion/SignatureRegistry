using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Person : NamedEntity
    {
        public virtual Department Department { get; set; }

        public virtual string Duty { get; set; } = null!;
    }
}
