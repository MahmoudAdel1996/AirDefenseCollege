using Nozom.Data.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nozom.Data.Entities.Storage
{
    public class Items: IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public List<Item> SameNameItems { get; set; }

    }
}
