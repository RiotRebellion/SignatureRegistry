using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProviderLicence : Entity
    {
        public virtual CryptoProvider CryptoProvider { get; set; } = null!;

        public virtual DateTime CreationDate {get;set;}

        public virtual LicenceType LicenceType { get; set; }
    }
}
