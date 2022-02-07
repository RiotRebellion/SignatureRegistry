using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Computer : Entity
    {
        public virtual Person User { get; set; }
        public virtual string IpAdress { get; set; } 
        public virtual string Identificatior { get; set; }
    }
}
