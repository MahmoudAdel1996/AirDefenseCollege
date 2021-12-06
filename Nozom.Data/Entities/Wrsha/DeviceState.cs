using Nozom.Data.EntityInterfaces;
using System.ComponentModel.DataAnnotations;

namespace Nozom.Data.Entities
{
    public class DeviceState : IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }
    }
}
