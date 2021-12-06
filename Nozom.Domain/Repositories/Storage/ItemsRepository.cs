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
    public class ItemsRepository : SimpleCrudRepository<WrshaDbContext, Items, ItemsDTO, int>
    {
        public ItemsRepository(WrshaDbContext dbContext) : base(dbContext)
        { }

        public override bool IsValidId(int itemsId) =>
            DbSet.Any(x => x.Id == itemsId);

        public List<CategoryWithQuantity> GetAllCategoryWithQuantity() =>
            DbSet.Include(x => x.Category).AsEnumerable()
            .GroupBy(s => s.CategoryId)
            .Select(o => new CategoryWithQuantity { 
                Id = o.First().CategoryId,
                Name = o.First().Category.Name,
                Quantity = o.Sum(d=> d.Quantity)
            }).ToList();
            

        public List<ItemsDTO> GetAllItemByCategoryId(int categoryId) =>
            Mapper.Map<List<ItemsDTO>>(
            DbSet.Where(x => x.CategoryId == categoryId)
            .Include(x => x.SameNameItems)).ToList();

    }
}
