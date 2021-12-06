using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nozom.Domain.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nozom.Domain.RepositoriesInterfaces
{
    public abstract class BaseRepository<TDbContext> where TDbContext : DbContext
    {
        protected readonly TDbContext Context;
        protected readonly IMapper Mapper;
        protected BaseRepository(TDbContext dbContext)
        {
            Context = dbContext;
            Mapper = new Mapper(RepositoryToDto.InitializeAll());
        }

        protected void SetEntityState(object entity, EntityState entityState)
        {
            Context.Entry(entity).State = entityState;
        }

    }
}
