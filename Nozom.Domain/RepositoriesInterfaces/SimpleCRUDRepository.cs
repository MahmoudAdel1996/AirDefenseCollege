using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Nozom.Data.EntityInterfaces;

namespace Nozom.Domain.RepositoriesInterfaces
{
    public abstract class SimpleCrudRepository<TDbContext, TDbSet, TDto, TPrimaryKey> : BaseRepository<TDbContext>
        where TDbContext : DbContext
        where TDbSet : class, IDbModel<TPrimaryKey>
        where TDto : class
        where TPrimaryKey : struct
    {

        protected readonly DbSet<TDbSet> DbSet;

        public SimpleCrudRepository(TDbContext dbContext) : base(dbContext)
        {
            DbSet = dbContext.Set<TDbSet>();
        }

        public abstract bool IsValidId(TPrimaryKey id);

        //Create
        public virtual TPrimaryKey Add(TDto dto, bool save = false)
        {
            var data = Mapper.Map<TDbSet>(dto);
            return Add(data, save);
        }
        protected TPrimaryKey Add(TDbSet data, bool save = false)
        {
            DbSet.Add(data);
            if (save) Context.SaveChanges();
            return data.Id;
        }

        public void Add(List<TDto> dtos, bool save = false)
        {
            DbSet.AddRange(Mapper.Map<List<TDto>, List<TDbSet>>(dtos));
            if (save) Context.SaveChanges();
        }

        //Read
        public TDto GetById(TPrimaryKey id) => Mapper.Map<TDto>(DbSet.Find(id));
        public List<TDto> GetAll() => Mapper.Map<List<TDbSet>, List<TDto>>(DbSet.ToList());
        public List<TDto> GetAll(Expression<Func<TDbSet, bool>> condition) =>
            Mapper.Map<List<TDbSet>, List<TDto>>(DbSet.Where(condition).ToList());

        protected TDbSet GetWithFilter(Func<TDbSet, bool> condition) => DbSet.Single(condition);

        //Delete
        public void Delete(TPrimaryKey id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Delete(TDto dto) => Delete(Mapper.Map<TDbSet>(dto).Id);
        public void Delete(TDbSet data) => Delete(data.Id);

        //Update
        public virtual bool Update(TDto dto)
        {
            var id = Mapper.Map<TDbSet>(dto).Id;
            return Update(dto, id);
        }

        public bool Update(TDto dto, TPrimaryKey id)
        {
            var data = DbSet.Find(id);
            Mapper.Map(dto, data);
            DbSet.Update(data);
            return true;
        }
    }
}
