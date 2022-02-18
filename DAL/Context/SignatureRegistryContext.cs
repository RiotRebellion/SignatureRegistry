using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DAL.Context
{
    public class SignatureRegistryContext : DbContext
    {
        public DbSet<AccordanceSertificate> AccordanceSertificates { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Department> Departments { get; set;}
        public DbSet<Destribution> Destributions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Formular> Formulars { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Software> Softwares { get; set; }
        public DbSet<SoftwareType> SoftwareTypes { get; set; }
        public DbSet<Support> Supports { get; set; }
        

        //UNDONE: Контекст подключения к БД

        public SignatureRegistryContext(DbContextOptions<SignatureRegistryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=DESKTOP-2TV6JC9;Initial Catalog=SIgnatureDB;Integrated Security=True");
        }
    }
}
