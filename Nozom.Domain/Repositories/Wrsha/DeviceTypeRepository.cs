using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class DeviceTypeRepository : SimpleCrudRepository<WrshaDbContext, DeviceType, DeviceTypeDTO, int>
    {
        public DeviceTypeRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int deviceTypeId) =>
            DbSet.Any(x => x.Id == deviceTypeId);

        public DeviceTypeDTO GetByType(string deviceType) =>
            Mapper.Map<DeviceTypeDTO>(
                DbSet.Single(x => x.Type == deviceType));
    }
}
