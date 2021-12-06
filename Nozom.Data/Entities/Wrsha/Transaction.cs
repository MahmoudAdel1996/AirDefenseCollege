using Nozom.Data.EntityInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nozom.Data.Entities
{
    public class Transaction : IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        public DateTime EnterDate { get; set; }

        public DateTime? ExitDate { get; set; }

        [ForeignKey("OwnerDaragaId")]
        public Daraga OwnerDaraga { get; set; }

        public int OwnerDaragaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string OwnerName { get; set; }

        [ForeignKey("ReciverDaragaId")]
        public Daraga ReciverDaraga { get; set; }

        public int ReciverDaragaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ReciverName { get; set; }

        [ForeignKey("HandOverToDaragaId")]
        public Daraga HandOverToDaraga { get; set; }

        public int? HandOverToDaragaId { get; set; }

        [MaxLength(50)]
        public string HandOverToName { get; set; }

        [ForeignKey("DeviceTypeId")]
        public DeviceType DeviceType { get; set; }

        public int DeviceTypeId { get; set; }

        [MaxLength(50)]
        public string DeviceName { get; set; }

        [ForeignKey("DeviceBranchId")]
        public Branch DeviceBranch { get; set; }

        public int DeviceBranchId { get; set; }

        [ForeignKey("DeviceStateId")]
        public DeviceState DeviceState { get; set; }
        public int DeviceStateId { get; set; } = 1;

        [MaxLength(255)]
        public string ProblemDeescription { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

        [MaxLength(50)]
        public string DeviceSrialNumber { get; set; }


    }
}
