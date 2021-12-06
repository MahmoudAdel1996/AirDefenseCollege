using Nozom.Data.EntityInterfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nozom.Data.Entities
{
    public class DeviceTransaction : IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string DeviceReciverName { get; set; }

        [ForeignKey("DeviceId")]
        public Device Device { get; set; }

        public int DeviceId { get; set; }

        [Required]
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
