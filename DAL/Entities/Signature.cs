using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Signature : Entity
    {
        public Person Owner { get; set; }
        public string PublicHashCode { get; set; } = null!;
        public string PrivateHashCode { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        //UNDONE : complete class Signature
    }
}
