using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Nozom.Domain.Repositories
{
    public class DeviceTransactionRepository : SimpleCrudRepository<WrshaDbContext, DeviceTransaction, DeviceTransactionDTO, int>
    {
        public DeviceTransactionRepository(WrshaDbContext dbContext) : base(dbContext)
        { }
        public override bool IsValidId(int deviceTransactionId) =>
            DbSet.Any(x => x.Id == deviceTransactionId);

        public DeviceTransactionDTO GetByDeviceReciverName(string deviceReciverName) =>
            Mapper.Map<DeviceTransactionDTO>(
                DbSet.Single(x => x.DeviceReciverName == deviceReciverName));

        public List<DeviceTransactionDTO> GetByDeviceId(int deviceId) =>
            Mapper.Map<List<DeviceTransactionDTO>>(
                DbSet.Where(x => x.DeviceId == deviceId)
                .Include(x => x.Device)
                .ToList());
    }
}
