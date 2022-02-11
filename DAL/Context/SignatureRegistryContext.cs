using DAL.Entities;
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
        public DbSet<Computer> Computers { get; set; }    

        public DbSet<CryptoProvider> CryptoProviders { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<ProviderLicence> ProviderLicences { get; set; }

        public DbSet<Signature> Signatures { get; set; }

        public DbSet<Token> Tokens { get; set; }        


        public SignatureRegistryContext(DbContextOptions<SignatureRegistryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
