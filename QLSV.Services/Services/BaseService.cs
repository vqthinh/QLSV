﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities;
using QLSV.Repositories.Repositories;

namespace QLSV.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class , IEntityBase
    {
        protected IUnitOfWork UnitOfWork;
        protected IBaseRepository<TEntity> Repository;

        public BaseService()
        {
            UnitOfWork = new UnitOfWork();
            Repository = UnitOfWork.Repository<TEntity>();
        }

        public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            return Repository.GetAll();
        }

        public bool Add(TEntity entity)
        {
            try
            {
                Repository.Add(entity);
                UnitOfWork.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Total()
        {
            return Repository.Total();
        }
    }
}
