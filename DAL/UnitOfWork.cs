using DAL.Context;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private SignatureRegistryContext context;
        private GenericRepository<Computer> computerRepository;
        private GenericRepository<CryptoProvider> cryptoProviderRepository;
        private GenericRepository<Department> departmentRepository;
        private GenericRepository<Person> personRepository;
        private GenericRepository<ProviderLicence> providerLicenceRepository;
        private GenericRepository<Signature> signatureRepository;
        private GenericRepository<Token> tokenRepository;

        public GenericRepository<Computer> ComputerRepository
        {
            get
            {
                if (this.computerRepository == null)
                {
                    this.computerRepository = new GenericRepository<Computer>(context);
                }
                return computerRepository;
            }
        }
        public GenericRepository<CryptoProvider> CryptoProviderRepository
        {
            get
            {
                if (this.cryptoProviderRepository == null)
                {
                    this.cryptoProviderRepository = new GenericRepository<CryptoProvider>(context);
                }
                return cryptoProviderRepository;
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
                return departmentRepository;
            }
        }
        public GenericRepository<Person> PersonRepository
        {
            get
            {
                if (this.personRepository == null)
                {
                    this.personRepository = new GenericRepository<Person>(context);
                }
                return personRepository;
            }
        }
        public GenericRepository<ProviderLicence> ProviderLicenceRepository
        {
            get
            {
                if (this.providerLicenceRepository == null)
                {
                    this.providerLicenceRepository = new GenericRepository<ProviderLicence>(context);
                }
                return providerLicenceRepository;
            }
        }
        public GenericRepository<Signature> SignatureRepository
        {
            get
            {
                if (this.signatureRepository == null)
                {
                    this.signatureRepository = new GenericRepository<Signature>(context);
                }
                return signatureRepository;
            }
        }
        public GenericRepository<Token> TokenRepository
        {
            get
            {
                if (this.tokenRepository == null)
                {
                    this.tokenRepository = new GenericRepository<Token>(context);
                }
                return tokenRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed == true)
            {
                if (disposing == true)
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
