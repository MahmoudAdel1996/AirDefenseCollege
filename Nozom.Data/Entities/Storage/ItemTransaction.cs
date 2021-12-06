using Nozom.Data.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nozom.Data.Entities.Storage
{
    public class ItemTransaction: IDbModel<int>
    {
        public int Id { get; set; }

        [ForeignKey("ItemsId")]
        public Items Items { get; set; }

        public int ItemsId { get; set; }

        public DateTime TransactionDate { get; set; }

        [ForeignKey("HandOverPersonId")]
        public Person HandOverPerson { get; set; }

        public int HandOverPersonId { get; set; }

        [ForeignKey("ReciverPersonId")]
        public Person ReciverPerson { get; set; }

        public int ReciverPersonId { get; set; }

        public int Quantity { get; set; }

        public decimal Paid { get; set; }
    }
}
