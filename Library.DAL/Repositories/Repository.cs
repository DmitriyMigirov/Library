using Library.DAL.Abstract.IRepositories;
using Library.DAL.EF;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : Base<TKey>
    {
        private readonly LibraryDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(LibraryDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual TEntity Get(TKey id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Update(TEntity entity)
        {
            TEntity find = Get(entity.Id);
            _context.Entry(find).CurrentValues.SetValues(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            TEntity find = Get(entity.Id);
            _dbSet.Remove(find);
        }
    }
}
