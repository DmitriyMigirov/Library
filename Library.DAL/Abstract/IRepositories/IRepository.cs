using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAL.Abstract.IRepositories
{
    public interface IRepository<TEntity, TKey> where TEntity : Base<TKey>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TKey id);

        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
