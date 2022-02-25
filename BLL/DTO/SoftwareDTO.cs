using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class SoftwareDTO
    {
        public string Name { get; set; } = null!;

        public string Version { get; set; } = null!;

        public int SoftwareId { get; set; }

        public int DestributionId { get; set; }
    }
}
