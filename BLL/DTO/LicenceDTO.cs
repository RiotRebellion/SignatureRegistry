using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class LicenceDTO
    {
        public string LicenceNumber { get; set; }

        public DateTime AcquisitionDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int SoftwareId { get; set; }

        public int ComputerId { get; set; }

        public int ContractId { get; set; }

        public int SupportId { get; set; }
    }
}
