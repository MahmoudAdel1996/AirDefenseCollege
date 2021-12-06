using Nozom.Data.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nozom.Data.Entities.Storage
{
    public class Category: IDbModel<int>
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Items> Items { get; set; }
    }
}
