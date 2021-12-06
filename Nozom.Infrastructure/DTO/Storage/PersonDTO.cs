using Nozom.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Infrastructure.DTO.Storage
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public Daraga Daraga { get; set; }
        public int DaragaId { get; set; }
        public string Name { get; set; }
        public Branch Branch { get; set; }
        public int BranchId { get; set; }
    }
}
