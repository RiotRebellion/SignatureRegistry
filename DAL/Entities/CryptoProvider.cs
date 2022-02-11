using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CryptoProvider : NamedEntity
    {
        public virtual string Version { get; set; } = null!;
    }
}
