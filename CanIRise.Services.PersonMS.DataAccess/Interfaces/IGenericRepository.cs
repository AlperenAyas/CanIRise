using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class,ITable,new()
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid Id);
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter);
        List<TEntity> GetAll();
        TEntity GetByFilter(Expression<Func<TEntity, bool>> filter);

    }
}
