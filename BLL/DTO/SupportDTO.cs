using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class SupportDTO
    {
        public string ActivationCode { get; set; } = null!;

        public DateTime ExpirationDate { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }
    }
}
