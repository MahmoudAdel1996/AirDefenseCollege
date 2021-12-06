using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Collections.Generic;
using System.Linq;
namespace Nozom.Domain.Repositories
{
    public class DeviceRepository : SimpleCrudRepository<WrshaDbContext, Device, DeviceDTO, int>
    {
        public DeviceRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int deviceTypeId) =>
            DbSet.Any(x => x.Id == deviceTypeId);

        public DeviceDTO GetByName(string deviceName) =>
            Mapper.Map<DeviceDTO>(
                DbSet.Single(x => x.DeviceName == deviceName));

        public List<DeviceDTO> GetByType(int deviceTypeid) =>
            Mapper.Map<List<DeviceDTO>>(
                DbSet.Where(x => x.DeviceTypeId == deviceTypeid)
                .Include(x => x.DeviceType)
                .ToList());
    }
}
