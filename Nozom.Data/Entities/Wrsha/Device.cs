using Nozom.Data.EntityInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nozom.Data.Entities
{
    public class Device : IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string DeviceName { get; set; }

        [ForeignKey("DeviceTypeId")]
        public DeviceType DeviceType { get; set; }

        public int DeviceTypeId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(50)]
        public string StoredBy { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
