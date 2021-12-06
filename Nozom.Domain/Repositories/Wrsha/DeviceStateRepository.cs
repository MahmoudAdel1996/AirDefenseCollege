using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class DeviceStateRepository : SimpleCrudRepository<WrshaDbContext, DeviceState, DeviceStateDTO, int>
    {
        public DeviceStateRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int deviceStateId) =>
            DbSet.Any(x => x.Id == deviceStateId);

        public DaragaDTO GetByState(string deviceState) =>
            Mapper.Map<DaragaDTO>(
                DbSet.Single(x => x.State == deviceState));
    }
}
