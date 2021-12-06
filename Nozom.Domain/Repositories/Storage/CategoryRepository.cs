using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Data.Entities.Storage;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using Nozom.Infrastructure.DTO.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nozom.Domain.Repositories.Storage
{
    public class CategoryRepository : SimpleCrudRepository<WrshaDbContext, Category, CategoryDTO, int>
    {
        public CategoryRepository(WrshaDbContext dbContext) : base(dbContext)
        { }

        public override bool IsValidId(int categoryId) =>
            DbSet.Any(x => x.Id == categoryId);
    }
}
