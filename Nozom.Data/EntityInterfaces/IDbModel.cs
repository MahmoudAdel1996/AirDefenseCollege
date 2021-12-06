using System.ComponentModel.DataAnnotations.Schema;

namespace Nozom.Data.EntityInterfaces
{
    public interface IDbModel<TPrimaryKey> where  TPrimaryKey : struct
    {
        [NotMapped]
        TPrimaryKey Id { get; }
    }
}
