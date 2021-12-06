using Nozom.Data.Entities.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Infrastructure.DTO.Storage
{
    public class ItemTransactionDTO
    {
        public int Id { get; set; }
        public ItemsDTO Items { get; set; }
        public int ItemsId { get; set; }
        public DateTime TransactionDate { get; set; }
        public PersonDTO HandOverPerson { get; set; }
        public int? HandOverPersonId { get; set; }
        public PersonDTO ReciverPerson { get; set; }
        public int? ReciverPersonId { get; set; }
        public int Quantity { get; set; }
        public decimal Paid { get; set; }
    }
}
