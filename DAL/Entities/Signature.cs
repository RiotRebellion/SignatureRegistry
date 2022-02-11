using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Signature : Entity
    {
        public virtual Person Owner { get; set; }
        public virtual string PublicHashCode { get; set; } = null!;
        public virtual string PrivateHashCode { get; set; } = null!;
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
    }
}
