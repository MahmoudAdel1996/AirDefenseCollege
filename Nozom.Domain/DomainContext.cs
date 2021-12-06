using Nozom.Data.Entities;
using Nozom.Domain.Repositories;
using Nozom.Domain.Repositories.Storage;
using Nozom.Infrastructure.DTO;
using System;
using System.Collections.Generic;

namespace Nozom.Domain
{
    public class DomainContext : IDisposable
    {
        private readonly WrshaDbContext _context;

        public DaragaRepository Daragat { get; private set; }
        public BranchRepository Branchs { get; private set; }
        public DeviceStateRepository DeviceStates { get; private set; }
        public DeviceTypeRepository DeviceTypes { get; private set; }
        public TransactionRepository Transactions { get; private set; }
        public DeviceTransactionRepository DeviceTransactions { get; private set; }
        public DeviceRepository Devices { get; private set; }
        public CategoryRepository Category { get; set; }
        public ItemsRepository Items { get; set; }
        public ItemTransactionRepository ItemTransaction { get; set; }
        public PersonRepository Person { get; set; }

        public DomainContext(WrshaDbContext dbContext, params Type[] repoTypes)
        {
            //Building Db Context
            _context = dbContext;

            //Building Repositories
            if (repoTypes.Length == 0) RepositoriesInitAll();
            else RepositoriesInit(repoTypes);
        }

        private void RepositoriesInitAll()
        {
            Daragat = new DaragaRepository(_context);
            Branchs = new BranchRepository(_context);
            DeviceStates = new DeviceStateRepository(_context);
            DeviceTypes = new DeviceTypeRepository(_context);
            Transactions = new TransactionRepository(_context);
            DeviceTransactions = new DeviceTransactionRepository(_context);
            Devices = new DeviceRepository(_context);
            Category = new CategoryRepository(_context);
            Items = new ItemsRepository(_context);
            ItemTransaction = new ItemTransactionRepository(_context);
            Person = new PersonRepository(_context);
        }

        private void RepositoriesInit(IEnumerable<Type> repoTypes)
        {
            foreach (var type in repoTypes)
            {
                if (type == typeof(DaragaRepository)) Daragat = new DaragaRepository(_context);
                else if (type == typeof(BranchRepository)) Branchs = new BranchRepository(_context);
                else if (type == typeof(DeviceStateRepository)) DeviceStates = new DeviceStateRepository(_context);
                else if (type == typeof(DeviceTypeRepository)) DeviceTypes = new DeviceTypeRepository(_context);
                else if (type == typeof(TransactionRepository)) Transactions = new TransactionRepository(_context);
                else if (type == typeof(DeviceTransactionRepository)) DeviceTransactions = new DeviceTransactionRepository(_context);
                else if (type == typeof(DeviceRepository)) Devices = new DeviceRepository(_context);
                else if (type == typeof(CategoryRepository)) Category = new CategoryRepository(_context);
                else if (type == typeof(ItemsRepository)) Items = new ItemsRepository(_context);
                else if (type == typeof(ItemTransactionRepository)) ItemTransaction = new ItemTransactionRepository(_context);
                else if (type == typeof(PersonRepository)) Person = new PersonRepository(_context);
            }
        }

        public int Complete() => _context.SaveChanges();
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
