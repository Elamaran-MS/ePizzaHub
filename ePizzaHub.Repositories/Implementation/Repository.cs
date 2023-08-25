using ePizzaHub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Repositories.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        void IRepository<TEntity>.Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Delete(object id)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository<TEntity>.Find(object id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        int IRepository<TEntity>.SaveChanges()
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
