using Nozom.Data.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nozom.Data.Entities.Storage
{
    public class Person: IDbModel<int>
    {
        public int Id { get; set; }

        [ForeignKey("DaragaId")]
        public Daraga Daraga { get; set; }

        public int DaragaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("BranchId")]
        public Branch Branch { get; set; }

        public int BranchId { get; set; }
    }
}
