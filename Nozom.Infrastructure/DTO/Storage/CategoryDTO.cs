using Nozom.Data.Entities.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Infrastructure.DTO.Storage
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Items> Items { get; set; }
    }
    public class CategoryWithQuantity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
