using Nozom.Data.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nozom.Data.Entities.Storage
{
    public class Item : IDbModel<int>
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Serial { get; set; }

    }
}
