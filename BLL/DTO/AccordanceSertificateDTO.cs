using BLL.Common.Mapping;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class AccordanceSertificateDTO : IMapWith<AccordanceSertificate>
    {
        public string RegNum { get; set; } = null!;

        public int FormularId { get; set; }

        public DateTime AcquisitionDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime? ProlongDate { get; set; }
    }
}
