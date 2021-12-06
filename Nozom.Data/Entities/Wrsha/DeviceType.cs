using Nozom.Data.EntityInterfaces;
using System.ComponentModel.DataAnnotations;

namespace Nozom.Data.Entities
{
    public class DeviceType : IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
