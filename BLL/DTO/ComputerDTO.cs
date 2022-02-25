using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ComputerDTO
    {
        public string MacAddress { get; set; } = null!;

        public byte[] IpAddress { get; set; } = null!;

        public string InvNumber { get; set; }

        public int EmployeeID { get; set; }

        public string Location { get; set; }

        public DateTime? LastAutorization { get; set; }
    }
}
