using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class SoftwareTypeDTO
    {
        public string Name { get; set; } = null!;
        public SoftwareLocationDTO SoftwareLocation { get; set; }
    }
}
