using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    internal class SignatureRegistryContext : DbContext
    {
        public SignatureRegistryContext(DbContextOptions<SignatureRegistryContext> options) : base(options)
        {

        }
    }
}
