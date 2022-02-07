using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Person : NamedEntity
    {
        public Department Department { get; set; }

        public string Duty { get; set; } = null!;
    }
}
