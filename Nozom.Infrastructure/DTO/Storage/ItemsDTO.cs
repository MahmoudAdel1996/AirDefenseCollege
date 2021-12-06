using Nozom.Data.Entities.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Infrastructure.DTO.Storage
{
    public class ItemsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public List<ItemDTO> SameNameItems { get; set; }
    }
}
