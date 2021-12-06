using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Data.Entities.Storage;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nozom.Domain.Repositories.Storage
{
    public  class ItemTransactionRepository : SimpleCrudRepository<WrshaDbContext, ItemTransaction, ItemTransactionDTO, int>
    {
        public ItemTransactionRepository(WrshaDbContext dbContext) : base(dbContext)
        { }

        public override bool IsValidId(int itemTransactioId) =>
            DbSet.Any(x => x.Id == itemTransactioId);

        public List<ItemTransactionDTO> GetAllWithDetails() =>
            Mapper.Map<List<ItemTransactionDTO>>(
                DbSet.Include(x => x.HandOverPerson)
                .Include(x => x.ReciverPerson)
                .Include(x => x.Items)).ToList();
    }
}

