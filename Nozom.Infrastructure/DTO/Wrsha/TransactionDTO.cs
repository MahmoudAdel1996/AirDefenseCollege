using System;

namespace Nozom.Infrastructure.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public DateTime EnterDate { get; set; }

        public DateTime? ExitDate { get; set; }

        public DaragaDTO OwnerDaraga { get; set; }

        public int OwnerDaragaId { get; set; }

        public string OwnerName { get; set; }

        public DaragaDTO ReciverDaraga { get; set; }

        public int ReciverDaragaId { get; set; }

        public string ReciverName { get; set; }

        public DaragaDTO HandOverToDaraga { get; set; }

        public int? HandOverToDaragaId { get; set; }

        public string HandOverToName { get; set; }

        public DeviceTypeDTO DeviceType { get; set; }

        public int DeviceTypeId { get; set; }

        public string DeviceName { get; set; }

        public string DeviceSrialNumber { get; set; }

        public BranchDTO DeviceBranch { get; set; }

        public int DeviceBranchId { get; set; }

        public string ProblemDeescription { get; set; }

        public string Notes { get; set; }

        public DeviceStateDTO DeviceState { get; set; }
        
        public int DeviceStateId { get; set; } = 1;
    }
}
