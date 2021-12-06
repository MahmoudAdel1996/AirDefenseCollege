using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure;
using Nozom.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class TransactionRepository: SimpleCrudRepository<WrshaDbContext, Transaction, TransactionDTO, int>
    {
        public TransactionRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int transactionId) =>
            DbSet.Any(x => x.Id == transactionId);

        public List<TransactionDTO> GetAllWithDetails() =>
            Mapper.Map<List<TransactionDTO>>(
                DbSet.Include(x => x.DeviceBranch)
                .Include(x => x.DeviceState)
                .Include(x => x.HandOverToDaraga)
                .Include(x => x.OwnerDaraga)
                .Include(x => x.ReciverDaraga)
                .Include(x => x.DeviceType)
                .OrderByDescending(x => x.EnterDate)
                .ToList());

        public List<TransactionDTO> GetAllWithSomeDetails() =>
           Mapper.Map<List<TransactionDTO>>(
               DbSet.Include(x => x.DeviceBranch)
               .Include(x => x.DeviceType)
               .OrderByDescending(x => x.EnterDate)
               .ToList());

        public void UpdateTransactionState(int transactionId)
        {
            var transaction = DbSet.Find(transactionId);
            transaction.DeviceStateId = (int)DeviceStatus.Done;
            DbSet.Update(transaction);
        }
    }
}
