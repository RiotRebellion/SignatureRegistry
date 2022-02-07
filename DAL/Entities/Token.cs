using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Token : NamedEntity
    {
        public Person? Owner { get; set; }

        public Signature? Signature { get; set; }
        
    }
}
