using Microsoft.EntityFrameworkCore;
using Nozom.Data.Entities;
using Nozom.Data.Entities.Storage;
using Nozom.Domain.RepositoriesInterfaces;
using Nozom.Infrastructure.DTO.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nozom.Domain.Repositories.Storage
{
    public class PersonRepository : SimpleCrudRepository<WrshaDbContext, Person, PersonDTO, int>
    {
        public PersonRepository(WrshaDbContext dbContext) : base(dbContext)
        { }

        public override bool IsValidId(int personId) =>
            DbSet.Any(x => x.Id == personId);

        public PersonDTO GetPersonByName(string personName) =>
            Mapper.Map<PersonDTO>(
                DbSet.SingleOrDefault(x => x.Name == personName));

        

    }
}