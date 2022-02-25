using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class FormularDTO
    {
        public string Name { get; set; } = null!;

        public string SerialKey { get; set; } = null!;

        public string? OrgRegNumber { get; set; }

        public string? ProtectionKey { get; set; }
    }
}
