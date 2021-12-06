using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Infrastructure.DTO
{
    public class DeviceTransactionDTO
    {
        public int Id { get; set; }
        public string DeviceReciverName { get; set; }
        public int DeviceId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
