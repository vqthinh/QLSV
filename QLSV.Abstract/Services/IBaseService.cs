using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QLSV.Entities;

namespace QLSV.Abstract.Services
{
    public interface IBaseService<TEntity> where TEntity : class , IEntityBase
    {
        IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);

        bool Add(TEntity entity);

        int Total();
    }
}
