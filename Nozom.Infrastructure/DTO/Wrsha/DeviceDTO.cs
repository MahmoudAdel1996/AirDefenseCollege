using System;

namespace Nozom.Infrastructure.DTO
{
    public class DeviceDTO
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public int DeviceTypeId { get; set; }
        public int Quantity { get; set; }
        public string StoredBy { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}
