using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class DestributionDTO
    {
        public string Number { get; set; } = null!;

        public string? OrgRegNumber { get; set; }

        public int FormularId { get; set; }
    }
}
