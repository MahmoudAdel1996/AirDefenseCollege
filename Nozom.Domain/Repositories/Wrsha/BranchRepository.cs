using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class BranchRepository : SimpleCrudRepository<WrshaDbContext, Branch, BranchDTO, int>
    {
        public BranchRepository(WrshaDbContext dbContext) : base(dbContext)
        { }

        public override bool IsValidId(int branchId) =>
            DbSet.Any(x => x.Id == branchId);

        public BranchDTO GetByName(string branchName) =>
            Mapper.Map<BranchDTO>(
                DbSet.Single(x => x.Name == branchName));
    }
}
