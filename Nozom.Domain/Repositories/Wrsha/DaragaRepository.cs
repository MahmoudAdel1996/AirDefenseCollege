using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class DaragaRepository : SimpleCrudRepository<WrshaDbContext, Daraga, DaragaDTO, int>
    {
        public DaragaRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int daragaId) =>
            DbSet.Any(x => x.Id == daragaId);

        public DaragaDTO GetByName(string daragaName) =>
            Mapper.Map<DaragaDTO>(
                DbSet.Single(x => x.Name == daragaName));
    }
}
