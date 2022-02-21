using DAL.Context;
using DAL.Entities;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace DAL
{

    //UNDONE: Подключение к бд через юнит оф ворк
    public class UnitOfWork : IDisposable
    {
        private SignatureRegistryContext context;

        private GenericRepository<AccordanceSertificate> accordanceSertificateRepository;
        private GenericRepository<Computer> computerRepository;
        private GenericRepository<Contract> contractRepository;
        private GenericRepository<Department> departmentRepository;
        private GenericRepository<Destribution> destributionRepository;
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Formular> formularRepository;
        private GenericRepository<Licence> licenceRepository;
        private GenericRepository<Software> softwareRepository;
        private GenericRepository<SoftwareType> softwareTypeRepository;
        private GenericRepository<Support> supportRepository;

        public UnitOfWork(DbContextOptions<SignatureRegistryContext> options)
        {
            context = new SignatureRegistryContext(options);
        }

        public GenericRepository<AccordanceSertificate> AccordanceSertificateRepository
        {
            get
            {
                if (this.accordanceSertificateRepository == null)
                {
                    this.accordanceSertificateRepository = new GenericRepository<AccordanceSertificate>(context);
                }
                return this.accordanceSertificateRepository;
            }
        }

        public GenericRepository<Computer> ComputerRepository
        {
            get
            {
                if (this.computerRepository == null)
                {
                    this.computerRepository = new GenericRepository<Computer>(context);
                }
                return this.computerRepository;
            }
        }

        public GenericRepository<Contract> ContractRepository
        {
            get
            {
                if (this.contractRepository == null)
                {
                    this.contractRepository = new GenericRepository<Contract>(context);
                }
                return this.contractRepository;
            }
        }

        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<Department>(context);
                }
                return this.departmentRepository;
            }
        }

        public GenericRepository<Destribution> DestributionRepository
        {
            get
            {
                if (this.destributionRepository == null)
                {
                    this.destributionRepository = new GenericRepository<Destribution>(context);
                }
                return this.destributionRepository;
            }
        }

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(context);
                }
                return this.employeeRepository;
            }
        }

        public GenericRepository<Formular> FormularRepository
        {
            get
            {
                if (this.formularRepository == null)
                {
                    this.formularRepository = new GenericRepository<Formular>(context);
                }
                return this.formularRepository;
            }
        }

        public GenericRepository<Licence> LicenceRepository
        {
            get
            {
                if (this.licenceRepository == null)
                {
                    this.licenceRepository = new GenericRepository<Licence>(context);
                }
                return this.licenceRepository;
            }
        }

        public GenericRepository<Software> SoftwareRepository
        {
            get
            {
                if (this.softwareRepository == null)
                {
                    this.softwareRepository = new GenericRepository<Software>(context);
                }
                return this.softwareRepository;
            }
        }

        public GenericRepository<SoftwareType> SoftwareTypeRepository
        {
            get
            {
                if (this.softwareTypeRepository == null)
                {
                    this.softwareTypeRepository = new GenericRepository<SoftwareType>(context);
                }
                return this.softwareTypeRepository;
            }
        }

        public GenericRepository<Support> SupportRepository
        {
            get
            {
                if (this.supportRepository == null)
                {
                    this.supportRepository = new GenericRepository<Support>(context);
                }
                return this.supportRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed == false)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
